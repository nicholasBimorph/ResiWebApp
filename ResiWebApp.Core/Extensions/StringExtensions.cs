using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace ResiWebApp.Core.Extensions
{
    public static class StringExtensions
    {
        /// <summary>
        /// Splits a camel case string in
        /// to individual words.
        /// For example, AreaType will become Area Type.
        /// </summary>
        public static string SplitCamelCase(this string stringToProcess)
        {
            return Regex.Replace(
                Regex.Replace(
                    stringToProcess,
                    @"(\P{Ll})(\P{Ll}\p{Ll})",
                    "$1 $2"
                ),
                @"(\p{Ll})(\P{Ll})",
                "$1 $2"
            );
        }

    }
}
