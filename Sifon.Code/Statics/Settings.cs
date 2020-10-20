﻿using System;
using System.Collections.Generic;
using System.IO;
using Sifon.Code.Helpers;

namespace Sifon.Code.Statics
{
    public static class Settings
    {
        public const string ProductVersion = "Sifon v0.99 (BETA)";
        public const string BackupInfoFile = "BackupInfo.xml";
        public const string RemoteDirectory = "Sifon";

        public static class Services
        {
            public const string MarketingAutomation = "MarketingAutomationService";
            public const string IndexWorker = "IndexWorker";
            public const string ProcessingEngineService = "ProcessingEngineService";
        }

        public static class Process
        {
            public const string MarketingAutomationEngine = "Sitecore.MAEngine";
            public const string Indexer = "Sitecore.XConnectSearchIndexer";
            public const string ProcessingEngine = "Sitecore.ProcessingEngine";
            public const string PublishingHost = "Sitecore.Framework.Publishing.Host";
        }

        public static class Folders
        {
            public static string Cache = Path.Combine(Environment.CurrentDirectory, "Cache");
            public static string Profiles => Path.Combine(Environment.CurrentDirectory, "Settings");
            public static string Plugins => Path.Combine(Environment.CurrentDirectory, "Sifon.Plugins");
            public static string Core => Path.Combine(Environment.CurrentDirectory, "PowerShell\\Core");
            public static string Module => Path.Combine(Environment.CurrentDirectory, "PowerShell\\Module");
        }

        public static class CacheFolder
        {
            public static string BackupInfo => Path.Combine(Folders.Cache, "BackupInfoFile.xml");
        }

        public static class SettingsFolder
        {
            public static string ProfilesPath = Path.Combine(Folders.Profiles, "Profiles.xml");
            public static string ContainersPath = Path.Combine(Folders.Profiles, "Containers.xml");
            public static string SqlProfilesPath = Path.Combine(Folders.Profiles, "SQL.xml");
            public static string SettingsPath = Path.Combine(Folders.Profiles, "Settings.xml");
        }

        public static class Regex
        {
            public static class Plugins
            {
                public static string MetacodeSynthax = "###\\s*(\\$\\w*)\\s*=\\s*new\\s*(.*)::(.*)\\(((\"?[^\"]*\"?)*)\\)";

                public static string Dependencies = "###\\s*Dependencies:\\s*(.*)";
                public static string DependenciesToExtract = "\\\"([^\"]*)\\\"";
            }
        }

        public static class Scripts
        {
            public static class Remote
            {
                public static string Initialize => Path.Combine(Folders.Core, "Initialize-Remote.ps1");
            }
        }

        public const string ManualEntry = "== enter manually ==";

        public static class Labels
        {
            public const string Reveal = "reveal";
            public const string Hide = "hide";
        }

        public static class Profiles
        {
            public static class Parameters
            {
                public const string KeyPrefix = "key";
                public const string ValPrefix = "val";
            }
        }

        public static class Buttons
        {
            public const string Add = "Add";
            public const string Rename = "Rename";
            public const string SaveAndClose = "Save and close";

            public const string Backup = "Backup";
            public const string Restore = "Restore";
            public const string Loading = "Loading ...";
        }

        public static class Dropdowns
        {
            public const string NotSet = "== not set ==";
            public const string AddNewProfile = "== add new profile ==";
            public const string AddNewServer = "== add new server ==";
        }

        public static class Databases
        {
            public static string[] ForbiddenDatabases = {"master", "tempdb", "model", "msdb"};
        }

        public static class Sites
        {
            public static string[] Commerce = {"Authoring", "Ops", "Shops", "Minions", "BizFx"};
        }

        public static class Parameters
        {
            // from profile
            public const string Name = "Name";
            public const string Prefix = "Prefix";
            public const string AdminUsername = "AdminUsername";
            public const string AdminPassword = "AdminPassword";
            public const string Website = "Website";
            public const string Webroot = "Webroot";
            public const string Solr = "Solr";
            public const string ServerInstance = "ServerInstance";
            public const string InstancePrefix = "InstancePrefix";

            // TODO: Check usage and remove - gone into SqlCredentials
            public const string Username = "Username";
            public const string Password = "Password";

            public const string SqlCredentials = "SqlCredentials";
            public const string PortalCredentials = "PortalCredentials";

            //from containers
            public const string ProfileName = "ProfileName";
            public const string Repository = "Repository";

            public const string Folder = "Folder";

            //public const string AdminPassword = "AdminPassword";
            public const string SaPassword = "SaPassword";

            //public const string InstanceFolder = "instanceFolder";

            // from the forms: backup-remove-restore
            //public const string InstanceName = "instanceName";
            public const string TargetFolder = "targetFolder";
            public const string Databases = "databases";
            public const string Activity = "activity";

            public const string XConnect = "XConnect";
            public const string IdentityServer = "IdentityServer";
            public const string Horizon = "Horizon";
            public const string HorizonFolder = "HorizonFolder";
            public const string PublishingService = "PublishingService";
            public const string PublishingServiceFolder = "PublishingServiceFolder";
            public const string XConnectFolder = "XConnectFolder";
            public const string IdentityServerFolder = "IdentityServerFolder";

            public const string Hostname = "Hostname";
            public const string Type = "type";

            //todo: check if the below correct - and move out unwanted
            public static Dictionary<string, string> AsDictionary()
            {
                return StaticsHelper.AsDictionary(typeof(Parameters));
            }
        }

        public static class Xml
        {
            public static class Attributes
            {
                public const string Name = "name";
                public const string Value = "value";
                public const string Empty = "empty";
                public const string RemotingEnabled = "remoting";
                public const string Selected = "selected";
            }

            public static class Profile
            {
                public const string NodeListName = "profiles";
                public const string NodeName = "profile";

                public const string RemoteExecutionHost = "RemoteExecutionHost";
                public const string RemoteUsername = "RemoteUsername";
                public const string RemotePassword = "RemotePassword";
                public const string RemoteFolder = "RemoteFolder";
                public const string Name = "Name";
                public const string Prefix = "Prefix";
                public const string AdminUsername = "AdminUsername";
                public const string AdminPassword = "AdminPassword";
                public const string Webroot = "Webroot";
                public const string Website = "Website";
                public const string Solr = "Solr";
                public const string SqlServer = "SqlServer";
                public const string Parameters = "AdditionalParameters";
                public const string Parameter = "Parameter";
            }

            public static class ContainerProfile
            {
                public const string NodeListName = "containers";
                public const string NodeName = "profile";

                public const string ProfileName = "ProfileName";
                public const string Repository = "Repository";
                public const string Folder = "Folder";
                public const string AdminPassword = "AdminPassword";
                public const string SaPassword = "SaPassword";
            }

            public static class SettingRecord
            {
                public const string NodeListName = "settings";

                public const string PortalUsername = "PortalUsername";
                public const string PortalPassword = "PortalPassword";
            }

            public static class SqlServerRecord
            {
                public const string NodeListName = "servers";

                public const string NodeName = "server";

                public const string RecordName = "Name";
                public const string SqlServer = "SqlServer";
                public const string SqlAdminUsername = "SqlAdminUsername";
                public const string SqlAdminPassword = "SqlAdminPassword";
            }

            public static class Backup_Info
            {
                public const string NodeName = "backup";
                public const string Webroot = "Webroot";
                public const string SitecoreInstance = "SitecoreInstance";
            }
        }

        public static class Initialize
        {
            public const string ProgressActivityName = "Initializing remote";
        }
    }
}