using System;
using System.Windows.Forms;
using Sifon.Abstractions.Messages;
using Sifon.Forms.Initialize;
using Sifon.Forms.MainForm;
using Sifon.Code.Exceptions;
using Sifon.Code.Extensions;
using Sifon.Code.Logger;
using Sifon.Code.Providers.Profile;
using Sifon.Shared.MessageBoxes;
using Sifon.Statics;

namespace Sifon
{
    static class Program
    {
        private static readonly IDisplayMessage DisplayMessage = new DisplayMessage();

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var onStart = new OnStart();
            if (onStart.EnsureAdminRights() && onStart.IsValid)
            {
                try
                {
                    onStart.EnableLogger();
                    SimpleLog.Info("Sifon started.");

                    Application.Run(new Main());
                    SimpleLog.Info("Sifon finished.");
                }
                catch (Exception e)
                {
                    if (e.InnerException is RemoteNotInitializedException)
                    {
                        
                        if (DisplayMessage.ShowYesNo(Messages.General.YesNoCaption, Messages.Program.NoRemoteFolder))
                        {
                            var initializeForm = new InitRemote
                            {
                                StartPosition = FormStartPosition.CenterParent,
                                RemoteSettings = new ProfilesProvider().SelectedProfile

                            };
                            if (initializeForm.ShowDialog() == DialogResult.OK && initializeForm.RemoteFolder.NotEmpty())
                            {
                                initializeForm.Dispose();
                                Application.Run(new Main());
                            }
                            else
                            {
                                DisplayMessage.ShowError(Messages.Program.InitializeFailure, Messages.Program.CannotContinueRemoting);
                            }
                        }
                        else
                        {
                            DisplayMessage.ShowError(Messages.Program.RemoteExecutionError, Messages.Program.CannotContinueRemoting);
                        }
                    }
                    else
                    {
                        DisplayMessage.ShowError(Messages.Program.ExecutionError, Messages.Program.CannotContinueGeneric);
                        DisplayMessage.ShowError(e.Message, $"{e.Message}{Environment.NewLine}{e.StackTrace}");
                    }

                    SimpleLog.Log(e);
                }
            }
        }
    }
}