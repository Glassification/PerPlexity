// <copyright file="Rule.cs" company="Thomas Beckett">
// Copyright (c) Thomas Beckett. All rights reserved.
// </copyright>

namespace PerPlexity.RulesEngine.Rules
{
    using PerPlexity.Models;

    public abstract class Rule
    {
        public Rule()
        {
            this.Name = string.Empty;
            this.Description = string.Empty;
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public int Order { get; set; }

        public abstract bool Run(PlexFile file);
    }
}
