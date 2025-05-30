// <copyright file="PlexFile.cs" company="Thomas Beckett">
// Copyright (c) Thomas Beckett. All rights reserved.
// </copyright>

namespace PerPlexity.Models
{
    using System.IO;

    public sealed class PlexFile
    {
        public PlexFile(string name)
        {
            this.Name = Path.GetFileNameWithoutExtension(name);
            this.OriginalName = this.Name;
            this.Directory = Path.GetDirectoryName(name) ?? string.Empty;
            this.Extension = Path.GetExtension(name);
        }

        public string Name { get; set; }

        public string OriginalName { get; set; }

        public string Extension { get; set; }

        public string Directory { get; set; }

        public int Season { get; set; }

        public int Episode { get; set; }
    }
}
