using System;
using System.Security.Cryptography;
using System.Text;

namespace CR2W.FNV1A
{
    public sealed class FNV1A32HashAlgorithm
    {
        private const uint FnvHashInitial = 0x811C9DC5;
        private const int FnvHashPrime = 0x1000193;

        public static uint Compute(string input)
        {
            uint fnvHash = FnvHashInitial;
            byte[] data = Encoding.ASCII.GetBytes(input);

            // Return 0 on an empty string, otherwise a hash of the 
            // initial * prime is returned.
            if(data.Length == 0)
                return 0;

            for (int i = 0; i < data.Length; i++)
            {
                fnvHash ^= data[i];
                fnvHash *= FnvHashPrime;
            }

            // This is required because strings aren't null terminated
            fnvHash *= FnvHashPrime;
            return fnvHash;
        }
    }
}