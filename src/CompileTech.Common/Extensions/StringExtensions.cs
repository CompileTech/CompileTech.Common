﻿namespace CompileTech.Common.Extensions
{
    public static class StringExtensions
    {
        public static string ToCamelCase(this string str) => string.IsNullOrEmpty(str) || str.Length < 2 ? str.ToLowerInvariant() : char.ToLowerInvariant(str[0]) + str.Substring(1);
    }
}