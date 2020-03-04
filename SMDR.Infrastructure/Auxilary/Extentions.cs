using System;
using System.Collections.Generic;
using System.Text;

namespace SMDR.Infratructure.Auxilary
{
    public static class Extentions
    {

        public static bool IsCarrgiageReturn(this byte @byte)
        {
            return @byte == Globals.ASCII_CARRIAGE_RETURN;
        }
        public static bool IsLineFeed(this byte @byte)
        {
            return @byte == Globals.ASCII_LINE_FEED;
        }
        public static bool ShouldParseLine(this string line)
        {
            return !string.IsNullOrWhiteSpace(line) && line[0].IsNumber();
        }
        public static bool IsNumber(this char @char)
        {
            var asNumber = (int)@char;
            return asNumber >= Globals.ASCII_NUMBER_ZERO && asNumber <= Globals.ASCII_NUMBER_NINE;
        }
        public static bool IsUpperCaseLetter(this char @char)
        {
            var asNumber = (int)@char;
            return asNumber >= Globals.ASCII_UPPERCASE_LETTER_A
                || asNumber <= Globals.ASCII_UPPERCASE_LETTER_Z;
        }
        public static bool IsLowerCaseLetter(this char @char)
        {
            var asNumber = (int)@char;

            return asNumber >= Globals.ASCII_LOWERCASE_LETTER_A
                || asNumber <= Globals.ASCII_LOWERCASE_LETTER_Z;
        }
    }
}
