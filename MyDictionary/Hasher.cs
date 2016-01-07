using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDictionary
{
    public class Hasher
    {
        public static UInt64 calculateHash(string password)
        {
            UInt64 hashValue = 11400714819306691477ul;
            for (int i = 0; i < password.Length; i++)
            {
                hashValue += password[i];
                hashValue *= 11400714819306691477ul;
            }
            return hashValue;
        }
    }
}
