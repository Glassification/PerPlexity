// <copyright file="IntegerExtensions.cs" company="Thomas Beckett">
// Copyright (c) Thomas Beckett. All rights reserved.
// </copyright>

namespace PerPlexity.Extensions
{
    public static class IntegerExtensions
    {
        public static string TwoDigitString(this int value)
        {
            return value < 10 ? $"0{value}" : value.ToString();
        }
    }
}
