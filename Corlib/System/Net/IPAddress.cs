/*
 * Copyright(c) 2022 nifanfa, This code is part of the Moos licensed under the MIT licence.
 */
namespace System.Net
{
    public class IPAddress
    {
        public byte[] Address;

        public static IPAddress Parse(params byte[] IP)
        {
            return new IPAddress()
            {
                Address = new byte[]
                {
                    IP[0],
                    IP[1],
                    IP[2],
                    IP[3]
                }
            };
        }
    }
}
