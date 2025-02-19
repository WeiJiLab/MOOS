/*
 * Copyright(c) 2022 nifanfa, This code is part of the Moos licensed under the MIT licence.
 */
namespace System
{
    public static class Convert
    {
        internal static int ToUInt16(bool boolean)
        {
            return boolean ? 1 : 0;
        }

        internal static int ToInt16(bool boolean)
        {
            return boolean ? 1 : 0;
        }

        internal static int ToInt16(byte b)
        {
            return b;
        }

        internal static bool ToBoolean(int integer)
        {
            return integer != 0;
        }

        internal static byte ToByte(int v)
        {
            return (byte)v;
        }

        internal static byte ToByte(uint v)
        {
            return (byte)v;
        }

        internal static int ToInt32(byte b)
        {
            return b;
        }

        internal static int ToInt32(int b)
        {
            return b;
        }
    }
}
