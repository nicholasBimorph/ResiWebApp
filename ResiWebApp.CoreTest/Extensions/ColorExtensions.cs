using System;
using System.Drawing;

namespace ResiWebApp.CoreTest
{
    public static  class ColorExtensions
    {
        /// <summary>
        /// Interpolates two colors given a factor <paramref name="t"/>.
        /// </summary>
        /// <param name="c">The color to lerp from</param>
        /// <param name="other"> the color to lerp to.</param>
        /// <param name="t">A scalar value with a domain of 0-1</param>
        /// <returns></returns>
        public static Color LerpTo(this Color c, Color other, double t)
        {
            int a = (int)(c.A + (other.A - c.A) * t);
            int r = (int)(c.R + (other.R - c.R) * t);
            int g = (int)(c.G + (other.G - c.G) * t);
            int b = (int)(c.B + (other.B - c.B) * t);
            return Color.FromArgb(a, r, g, b);
        }
    }
}
