﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sifon.Forms.Base;
using Sifon.Code.Events;
using Sifon.Code.PowerShell;
using Sifon.Code.Statics;
using Sifon.Statics;
using Sifon.ViewModels;

namespace Sifon.Forms.Backup
{
    internal class BackupPresenter : BaseBackupRestorePresenter
    {
        private bool sitesReady = false;
        private bool databasesReady = false;
        private readonly IBackupView _view;
        private  ScriptWrapper<string> _scriptWrapper;

        internal BackupPresenter(IBackupView backupView) : base(backupView)
        {
            _view = backupView;
            _view.FormLoaded += Loaded;
            _view.InstanceChanged += async (s, e) => { await InstanceChanged(s, e as EventArgs<string>); };
            _view.ValidateBeforeClose += ValidateBeforeClose; // TODO: test async / await
            _view.BeforeFormClosing += ClosingForm;
        }

        private async void Loaded(object sender, EventArgs e)
        {
            _view.ToggleControls(false);
            _view.EnableDisableMainButton(false);
            
            var instances = await _siteProvider.GetSitecoreSites();
            _view.PopulateInstancesDropdown(instances);
        }

        private async Task InstanceChanged(object sender, EventArgs<string> e)
        {
            _view.EnableDisableMainButton(false);

            _view.ToggleControls(false);

            var bindings = await _siteProvider.GetBindings(e.Value);
            _view.PopulateHostnamesListboxForSite(bindings, ControlSettings.Grid.HostnameColumns);

            var viewModel = await BuildViewModel(e.Value);
            _view.SetFieldsAndCheckboxes(viewModel);

            await PopulateDatabases(viewModel, e.Value);

            _view.ToggleControls(true);
            _view.EnableDisableMainButton(true);
            _view.EnableDisableMainButton(null);
        }

        private async Task<BackupRemoverViewModel> BuildViewModel(string siteName)
        {
            var xconnectFolder = await _siteProvider.GetXconnect(siteName);
            var idsFolder = await _siteProvider.GetIDS(siteName);
            var horizonFolder = await _siteProvider.GetHorizon(siteName);
            var publishingFolder = await _siteProvider.GetPublishingService(siteName);
            var commerceSites = await _siteProvider.GetCommerceSites(siteName);

            return new BackupRemoverViewModel
            {
                XConnectFolder = xconnectFolder,
                IdentityFolder = idsFolder,
                HorizonFolder = horizonFolder,
                PublishingFolder = publishingFolder,
                CommerceSites = commerceSites.ToDictionary(s => s, s => s)
            };
        }

        private async Task PopulateDatabases(BackupRemoverViewModel viewModel, string selectedSiteName)
        {
            var selectedSitePrefix = _profileService.FindPrefixByName(selectedSiteName);

            var parameters = new Dictionary<string, dynamic>
            {
                { Settings.Parameters.ServerInstance, _profileService.SelectedProfileSql.SqlServer},
                { Settings.Parameters.InstancePrefix, selectedSitePrefix}
            };

            _scriptWrapper = new ScriptWrapper<string>(_profileService.SelectedProfile, _view, d => d.ToString());
            await _scriptWrapper.Run(Modules.Functions.GetDatabases, parameters);

            if (viewModel.CommerceSites.Any())
            {
                var commerceDatabases = await _siteProvider.GetCommerceDatabases(viewModel.CommerceSites.Last().Value);
                _scriptWrapper.Results.AddRange(commerceDatabases.Results);
            }

            if (_scriptWrapper.Errors.Any())
            {
                _view.DisplayErrors(_scriptWrapper.Errors.Select(ex => ex.Message));
                return;
            }

            viewModel.Databases = _scriptWrapper.Results.ToArray();
            _view.PopulateDatabasesListboxForSite(viewModel);
        }

        private void ClosingForm(object sender, EventArgs e)
        {
            _scriptWrapper?.Finish();
        }
    }
}
