// <copyright file="ReplaceRule.cs" company="Thomas Beckett">
// Copyright (c) Thomas Beckett. All rights reserved.
// </copyright>

namespace PerPlexity.RulesEngine.Rules
{
    using PerPlexity.Models;

    public sealed class ReplaceRule : Rule
    {
        public ReplaceRule()
            : base()
        {
            this.OldValue = string.Empty;
            this.NewValue = string.Empty;
        }

        public string OldValue { get; set; }

        public string NewValue { get; set; }

        public override bool Run(PlexFile file)
        {
            file.Name = file.Name.Replace(this.OldValue, this.NewValue);
            file.Name = string.Format(file.Name, file.Season, file.Episode);
            return true;
        }
    }
}
