/*
 * Copyright(c) 2022 nifanfa, This code is part of the OS-Sharp licensed under the MIT licence.
 */
namespace System
{
    public static class Math
    {
        public static int Abs(int value) 
        {
            return value < 0 ? value * -1 : value;
        }
    }
}
