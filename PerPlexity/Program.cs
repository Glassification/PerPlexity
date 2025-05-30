// <copyright file="Program.cs" company="Thomas Beckett">
// Copyright (c) Thomas Beckett. All rights reserved.
// </copyright>

namespace PerPlexity
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    using Newtonsoft.Json;
    using PerPlexity.RulesEngine;
    using PerPlexity.RulesEngine.Rules;
    using PerPlexity.Services;

    public class Program
    {
        public static void Main(string[] args)
        {
            var file = FileAccessService.GetFile(args[0]);
            var rules = FileAccessService.GetRules(PerPlexityFiles.AppDataDirectory);
            var ruleGroup = new RuleGroup(int.Parse(args[1]), rules);

            ruleGroup.Run(file);

            Console.WriteLine("Hello, World!");
        }
    }
}
