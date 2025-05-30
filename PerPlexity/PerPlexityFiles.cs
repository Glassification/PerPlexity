// <copyright file="PerPlexityFiles.cs" company="Thomas Beckett">
// Copyright (c) Thomas Beckett. All rights reserved.
// </copyright>

namespace PerPlexity
{
    using System;
    using System.IO;

    public static class PerPlexityFiles
    {
        private static readonly string ApplicationData;

        static PerPlexityFiles()
        {
            ApplicationData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

            Directory.CreateDirectory(AppDataDirectory);
        }

        public static string AppDataDirectory => Path.Combine(ApplicationData, "PerPlexity");
    }
}
