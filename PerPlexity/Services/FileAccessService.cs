// <copyright file="FileAccessService.cs" company="Thomas Beckett">
// Copyright (c) Thomas Beckett. All rights reserved.
// </copyright>

namespace PerPlexity.Services
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    using Newtonsoft.Json;
    using PerPlexity.Models;
    using PerPlexity.RulesEngine.Rules;

    public class FileAccessService
    {
        public FileAccessService()
        {
        }

        public static PlexFolder LoadFolder(string folderName)
        {
            var files = Directory.GetFiles(folderName);
            return new PlexFolder([.. files]);
        }

        public static PlexFile GetFile(string fileName)
        {
            return new PlexFile(fileName);
        }

        public static List<Rule> GetRules(string path)
        {
            try
            {
                var addFile = File.ReadAllText(Path.Combine(path, $"{nameof(AddRule)}.json"));
                var replaceFile = File.ReadAllText(Path.Combine(path, $"{nameof(ReplaceRule)}.json"));
                var stripFile = File.ReadAllText(Path.Combine(path, $"{nameof(StripRule)}.json"));

                var addRules = JsonConvert.DeserializeObject<List<AddRule>>(addFile) ?? [];
                var replaceRules = JsonConvert.DeserializeObject<List<ReplaceRule>>(replaceFile) ?? [];
                var stripRules = JsonConvert.DeserializeObject<List<StripRule>>(stripFile) ?? [];

                var rules = new List<Rule>();
                rules.AddRange(addRules);
                rules.AddRange(replaceRules);
                rules.AddRange(stripRules);

                return rules;
            }
            catch (Exception)
            {
                return [];
            }
        }
    }
}
