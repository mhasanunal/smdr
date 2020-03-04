using System;

namespace SMDR.Infratructure.Auxilary
{
    public class Globals
    {

        public static string GetDisconnectCause(string index)
        {
            byte byteValue = default(byte);
            try
            {
                byteValue = Convert.ToByte(index, 16);
            }
            catch (Exception)
            {
            }
            if (byteValue != default(byte))
            {
                DisconnectCauses.TryGetValue(byteValue, out string result);
                return result;
            }
            return null;
        }
        public static ISDN_Disconnect_Causes DisconnectCauses = new ISDN_Disconnect_Causes();
        public const int DEFAULT_BUFFER_SIZE = 1024;

        public const byte ASCII_LINE_FEED = 0x0A;
        public const byte ASCII_CARRIAGE_RETURN = 0x0D;

        public const byte ASCII_NUMBER_ZERO = 0x30;
        public const byte ASCII_NUMBER_NINE = 0x39;

        public const byte ASCII_LOWERCASE_LETTER_A = 0x61;
        public const byte ASCII_UPPERCASE_LETTER_A = 0x41;

        public const byte ASCII_UPPERCASE_LETTER_Z = 0x5A;
        public const byte ASCII_LOWERCASE_LETTER_Z = 0x7A;
    }
}
