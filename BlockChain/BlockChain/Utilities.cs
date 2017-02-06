﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BlockChain
{

    //classe contenente varie funzioni utili
    class Utilities
    {
        public static string ByteArrayToString(byte[] ba)
        {
            StringBuilder hex = new StringBuilder(ba.Length * 2);
            foreach (byte b in ba)
                hex.AppendFormat("{0:x2}", b);
            return hex.ToString();
        }

        public static byte[] StringToByteArray(string hex)
        {
            return Enumerable.Range(0, hex.Length)
                             .Where(x => x % 2 == 0)
                             .Select(x => Convert.ToByte(hex.Substring(x, 2), 16))
                             .ToArray();
        }

        public static string SHA2Hash(string strToHash)
        {
            return Utilities.ByteArrayToString(SHA256Managed.Create().ComputeHash(Encoding.ASCII.GetBytes(strToHash)));
        }

        public static byte[] SHA2HashBytes(string strToHash)
        {
            return SHA256Managed.Create().ComputeHash(Encoding.ASCII.GetBytes(strToHash));
        }
    }
}
