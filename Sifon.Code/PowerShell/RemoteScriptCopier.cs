﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Sifon.Abstractions.Profiles;
using Sifon.Code.Providers.Profile;
using Sifon.Code.Statics;
using Sifon.Code.Extensions;
using Sifon.Code.Model.Profiles;

namespace Sifon.Code.PowerShell
{
    public class RemoteScriptCopier
    {
        private readonly IProfile _profile;
        private readonly string _remoteMachine;
        private readonly string _username;
        private readonly string _password;

        private readonly ScriptWrapper<string> _scriptWrapper;

        public RemoteScriptCopier(IProfile profile, ISynchronizeInvoke invoke)
        {
            _profile = profile;
            _remoteMachine = profile.RemoteHost;
            _username = profile.RemoteUsername;
            _password = profile.RemotePassword;

            var fakeLocalProfile = new ProfilesProvider().CreateLocal();
            _scriptWrapper = new ScriptWrapper<string>(fakeLocalProfile, invoke, d => d.ToString());
        }
        
        //todo: is it used at all?
        public string UseProfileFolderIfRemote(string scriptPath)
        {
            return _profile.RemotingEnabled && _profile.RemoteFolder.NotEmpty() 
                ? Path.Combine(_profile.RemoteFolder, Path.GetFileName(scriptPath))
                : scriptPath;
        }

        public async Task<string> CopyIfRemote(string scriptPath)
        {
            if (_profile.RemotingEnabled)
            {
                var remoteFolder = await GetRemoteFolder();

                var parameters = Parameters;
                parameters.Add("Filename", scriptPath);
                parameters["RemoteDirectory"] = remoteFolder;
                await _scriptWrapper.Run(Modules.Functions.CopyFileToRemote, parameters);
                return _scriptWrapper.Results.FirstOrDefault();
            }

            return scriptPath;
        }

        public async Task<string> GetRemoteFolder()
        {
            await _scriptWrapper.Run(Modules.Functions.CopyFileToRemote, Parameters);
            return _scriptWrapper.Results.FirstOrDefault();
        }

        Dictionary<string, dynamic> Parameters => new Dictionary<string, dynamic>
        {
            {"RemoteHost", _remoteMachine},
            {"Username", _username},        //TODO: To secure credentials
            {"Password", _password},
            {"RemoteDirectory", Settings.RemoteDirectory}
        };
    }
}
