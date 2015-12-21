using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPC_GXT2Editor
{
    public static class Utils
    {
        public static uint GetHash(string str)
        {
            uint hash, i;
            char[] key = str.ToLower().ToCharArray();
            for (hash = i = 0; i < key.Length; i++)
            {
                hash += (uint)key[i];
                hash += (hash << 10);
                hash ^= (hash >> 6);
            }
            hash += (hash << 3);
            hash ^= (hash >> 11);
            hash += (hash << 15);
            return hash;
        }
        public static uint GetHash(byte[] data)
        {
            uint hash, i;
            for (hash = i = 0; i < data.Length; i++)
            {

                hash += (uint)data[i];
                hash += (hash << 10);
                hash ^= (hash >> 6);
            }
            hash += (hash << 3);
            hash ^= (hash >> 11);
            hash += (hash << 15);
            return hash;
        }
    }
}
