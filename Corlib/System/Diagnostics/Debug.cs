/*
 * Copyright(c) 2022 nifanfa, This code is part of the OS-Sharp licensed under the MIT licence.
 */
using Kernel;

#if KERNEL
namespace System.Diagnostics
{
    public static class Debug
    {
        public static void WriteLine(string s) 
        {
            Serial.WriteLine(s);
            s.Dispose();
        }

        public static void WriteLine()
        {
            Serial.WriteLine();
        }

        public static void Write(char c)
        {
            Serial.Write(c);
        }

        public static void Write(string s)
        {
            Serial.Write(s);
            s.Dispose();
        }
    }
}
#endif
