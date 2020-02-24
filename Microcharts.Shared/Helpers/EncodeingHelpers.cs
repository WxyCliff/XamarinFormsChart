// Copyright (c) Aloïs DENIEL. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

namespace Microcharts
{
    using System;
    using SkiaSharp;

    internal static class EncodeingHelpers
    {
        public static SKTypeface ToSKTypeface(this string text)
        {

            for (int i = 0; i <= text.Length - 1; i++)
            {
                if (char.IsWhiteSpace(text[i])) continue;
                if (char.IsNumber(text[i])) continue;
                if (char.IsSymbol(text[i])) continue;
                return SKFontManager.Default.MatchCharacter(text[i]);
            }

            return SKFontManager.Default.MatchCharacter(text[0]);

        }
    }
}
