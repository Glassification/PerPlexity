// <copyright file="AddRule.cs" company="Thomas Beckett">
// Copyright (c) Thomas Beckett. All rights reserved.
// </copyright>

namespace PerPlexity.RulesEngine.Rules
{
    using PerPlexity.Enums;
    using PerPlexity.Extensions;
    using PerPlexity.Models;

    public sealed class AddRule : Rule
    {
        public AddRule()
            : base()
        {
            this.Value = string.Empty;
        }

        public AddType AddType { get; set; }

        public string Value { get; set; }

        public override bool Run(PlexFile file)
        {
            file.Name = this.AddType switch
            {
                AddType.Prepend => $"{this.Value}{file.Name}",
                _ => $"{file.Name}{this.Value}",
            };
            file.Name = string.Format(file.Name, file.Season.TwoDigitString(), file.Episode.TwoDigitString());
            return true;
        }
    }
}
