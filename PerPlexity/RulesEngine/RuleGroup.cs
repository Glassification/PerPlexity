// <copyright file="RuleGroup.cs" company="Thomas Beckett">
// Copyright (c) Thomas Beckett. All rights reserved.
// </copyright>

namespace PerPlexity.RulesEngine
{
    using System.Collections.Generic;
    using System.Linq;

    using PerPlexity.Models;
    using PerPlexity.RulesEngine.Rules;

    public sealed class RuleGroup
    {
        private readonly List<Rule> rules;

        public RuleGroup(int id, List<Rule> rules)
        {
            this.RuleId = id;
            this.rules = [.. rules.Where(x => x.Id == this.RuleId).OrderBy(y => y.Order)];
        }

        public int RuleId { get; }

        public bool Run(PlexFile plexFile)
        {
            this.rules.ForEach(x => x.Run(plexFile));
            return true;
        }

        public bool Run(PlexFolder plexFolder)
        {
            foreach (var plexFile in plexFolder.Files)
            {
                this.Run(plexFile);
            }

            return true;
        }
    }
}
