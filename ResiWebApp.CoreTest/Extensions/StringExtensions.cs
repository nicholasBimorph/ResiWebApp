using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace ResiWebApp.CoreTest
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

        /// <summary>
        /// Filters a <paramref name="numericString"/> that contains non-numeric characters.
        /// </summary>
        /// <returns>
        /// Returns a <see cref="char"/> array of only numeric characters.
        /// </returns>
        public static char[] FilterNumericString(this string numericString)
        {
            var areaCharArray = numericString.ToCharArray();

            return areaCharArray.Where(char.IsDigit).ToArray();
        }

    }
}
