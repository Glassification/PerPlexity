// <copyright file="StripRule.cs" company="Thomas Beckett">
// Copyright (c) Thomas Beckett. All rights reserved.
// </copyright>

namespace PerPlexity.RulesEngine.Rules
{
    using PerPlexity.Models;

    public sealed class StripRule : Rule
    {
        public StripRule()
            : base()
        {
            this.Value = string.Empty;
        }

        public string Value { get; set; }

        public bool IsRegex { get; set; }

        public override bool Run(PlexFile file)
        {
            file.Name = file.Name.Replace(this.Value, string.Empty);
            return true;
        }
    }
}
