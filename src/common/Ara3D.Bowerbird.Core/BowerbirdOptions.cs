﻿using Ara3D.Utils;

namespace Ara3D.Bowerbird.Core
{
    public class BowerbirdOptions
    {
        public string AppName { get; set; }
        public string OrgName { get; set; }
        public DirectoryPath ScriptsFolder { get; set; }
        public DirectoryPath LibrariesFolder { get; set; }

        public static BowerbirdOptions CreateFromName(string orgName, string appName)
        {
            var appData = SpecialFolders.LocalApplicationData;
            return new BowerbirdOptions()
            {
                OrgName = orgName,
                AppName = appName,
                ScriptsFolder = appData.RelativeFolder(orgName, appName, "Scripts"),
                LibrariesFolder = appData.RelativeFolder(orgName, appName, "Libraries"),
            };
        }
    }
}