using System;
using System.Security.Cryptography;
using System.Text;

namespace CR2W.FNV1A
{
    public sealed class FNV1A32HashAlgorithm : HashAlgorithm
    {
        private const uint FnvHashPrime = 0x01000193;
        private const uint FnvHashInitial = 0x811C9DC5;

        private uint fnvhash;

        public FNV1A32HashAlgorithm()
        {
            this.Initialize();
            this.HashSizeValue = 32;
        }

        public override void Initialize()
        {
            this.fnvhash = FnvHashInitial;
        }

        public static uint HashString(string value)
        {
            if (String.IsNullOrEmpty(value))
                return 0;

            var fnv1a = new FNV1A32HashAlgorithm();
            var data = Encoding.ASCII.GetBytes(value);

            fnv1a.HashCore(data, 0, data.Length);

            return fnv1a.fnvhash * FnvHashPrime;
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