using RED.FNV1A;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Security.Cryptography;

namespace RED
{
    /// <summary>
    /// Represents a list of unique CName tags
    /// </summary>
    public sealed class TagList : HashSet<CName>
    {
        public TagList()
            : base(comparer)
        {
            
        }
        public TagList(IEnumerable<CName> names)
            : base(names, comparer)
        {

        }

        public override string ToString()
        {
            return String.Format("[{0}]", String.Join<CName>(",", this));
        }




        #region EqualityComparer
        private static readonly IEqualityComparer<CName> comparer = new CNameEqualityComparer();
        private class CNameEqualityComparer : IEqualityComparer<CName>
        {
            private static readonly HashAlgorithm fnv1a = new FNV1A32HashAlgorithm();
            public bool Equals(CName x, CName y)
            {
                return x.Equals(y);
            }
            public int GetHashCode(CName obj)
            {
                fnv1a.Initialize();
                fnv1a.ComputeHash(obj.ToByteArray(true));
                return BitConverter.ToInt32(fnv1a.Hash, 0);
            }
        }
        #endregion
    }
}