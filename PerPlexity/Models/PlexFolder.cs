// <copyright file="PlexFolder.cs" company="Thomas Beckett">
// Copyright (c) Thomas Beckett. All rights reserved.
// </copyright>

namespace PerPlexity.Models
{
    using System.Collections.Generic;

    public sealed class PlexFolder
    {
        public PlexFolder(List<string> files)
        {
            this.Files = [];
            foreach (string file in files)
            {
                this.Files.Add(new PlexFile(file));
            }
        }

        public List<PlexFile> Files { get; set; }
    }
}
