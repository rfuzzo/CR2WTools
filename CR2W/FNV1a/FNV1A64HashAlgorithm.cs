using System;
using System.Security.Cryptography;
using System.Text;

namespace CR2W.FNV1A
{
    public sealed class FNV1A64HashAlgorithm : HashAlgorithm
    {
        private const ulong FnvHashPrime = 0x00000100000001B3;
        private const ulong FnvHashInitial = 0xCBF29CE484222325;

        private ulong fnvhash;

        public FNV1A64HashAlgorithm()
        {
            this.Initialize();
            this.HashSizeValue = 64;
        }

        public override void Initialize()
        {
            this.fnvhash = FnvHashInitial;
        }

        public static ulong HashString(string value)
        {
            if(String.IsNullOrEmpty(value))
                return 0;

            var fnv1a = new FNV1A64HashAlgorithm();
            var data = Encoding.ASCII.GetBytes(value);

            fnv1a.HashCore(data, 0, data.Length);

            return fnv1a.fnvhash *= FnvHashPrime;
        }

        protected override void HashCore(byte[] array, int ibStart, int cbSize)
        {
            if (array == null)
            {
                throw new ArgumentNullException(nameof(array));
            }

            for (int i = ibStart; i < cbSize; i++)
            {
                this.fnvhash ^= array[i];
                this.fnvhash *= FnvHashPrime;
            }
        }

        protected override byte[] HashFinal()
        {
            return BitConverter.GetBytes(this.fnvhash);
        }
    }
}