using System;
using System.Security.Cryptography;
using System.Text;

namespace CR2W.FNV1A
{

    public sealed class Fnv1a32 : HashAlgorithm
    {
        public uint FnvPrime = unchecked(16777619);

        public uint FnvOffsetBasis = unchecked(2166136261);

        private uint hash;

        public Fnv1a32()
        {
            this.Reset();
        }

        public override void Initialize()
        {
            this.Reset();
        }

        protected override void HashCore(byte[] array, int ibStart, int cbSize)
        {
            for (var i = ibStart; i < cbSize; i++)
            {
                unchecked
                {
                    this.hash ^= array[i];
                    this.hash *= FnvPrime;
                }
            }
        }

        public UInt32 ComputeHash(string value)
        {
            var hash = base.ComputeHash(Encoding.Default.GetBytes(value));
            return BitConverter.ToUInt32(hash, 0);
        }

        protected override byte[] HashFinal()
        {
            return BitConverter.GetBytes(this.hash);
        }

        private void Reset()
        {
            this.hash = FnvOffsetBasis;
        }
    }
}