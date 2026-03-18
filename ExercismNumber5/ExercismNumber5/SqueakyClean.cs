using System;
using System.Collections.Generic;
using System.Text;

namespace ExercismNumber5
{
    internal static class SqueakyClean
    {
        public static string Clean(string identifier)
        {
            System.Text.StringBuilder sb = new();
            bool kebabCase = false;
            foreach (var c in identifier)
            {
                sb.Append(c switch
                {
                    _ when c >= 945 && c <= 969 => default,
                    _ when kebabCase => char.ToUpperInvariant(c),
                    _ when char.IsWhiteSpace(c) => '_',
                    _ when char.IsControl(c) => "CTRL",
                    _ when char.IsLetter(c) => c,
                    _ => default,
                });
                kebabCase = c.Equals('-');
            }
            return sb.ToString();
        }
    }
}
