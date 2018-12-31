using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;

namespace CR2W.Types
{

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class VirtualDictionary<TKey, TValue> : IDictionary<TKey, TValue>
    {
        public Dictionary<TKey, TValue> wrappedDictionary;

        public VirtualDictionary()
        {
            wrappedDictionary = new Dictionary<TKey, TValue>();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VirtualDictionary{TKey,TValue}"/> class that is empty, has the specified initial capacity, and uses the default equality comparer for the key type.
        /// </summary>
        /// <param name="capacity">The initial number of elements that the <see cref="T:System.Collections.Generic.VirtualDictionary`2"/> can contain.</param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="capacity"/> is less than 0.</exception>
        public VirtualDictionary(int capacity)
        {
            wrappedDictionary = new Dictionary<TKey, TValue>(capacity);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VirtualDictionary{TKey,TValue}"/> class that is empty, has the default initial capacity, and uses the specified <see cref="T:System.Collections.Generic.IEqualityComparer`1"/>.
        /// </summary>
        /// <param name="comparer">The <see cref="T:System.Collections.Generic.IEqualityComparer`1"/> implementation to use when comparing keys, or null to use the default <see cref="T:System.Collections.Generic.EqualityComparer`1"/> for the type of the key.</param>
        public VirtualDictionary(IEqualityComparer<TKey> comparer)
        {
            wrappedDictionary = new Dictionary<TKey, TValue>(comparer);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VirtualDictionary{TKey,TValue}"/> class that is empty, has the specified initial capacity, and uses the specified <see cref="T:System.Collections.Generic.IEqualityComparer`1"/>.
        /// </summary>
        /// <param name="capacity">The initial number of elements that the <see cref="VirtualDictionary{TKey,TValue}"/> can contain.</param><param name="comparer">The <see cref="T:System.Collections.Generic.IEqualityComparer`1"/> implementation to use when comparing keys, or null to use the default <see cref="T:System.Collections.Generic.EqualityComparer`1"/> for the type of the key.</param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="capacity"/> is less than 0.</exception>
        public VirtualDictionary(int capacity, IEqualityComparer<TKey> comparer)
        {
            wrappedDictionary = new Dictionary<TKey, TValue>(capacity, comparer);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VirtualDictionary{TKey,TValue}"/> class that contains elements copied from the specified <see cref="T:System.Collections.Generic.IDictionary`2"/> and uses the default equality comparer for the key type.
        /// </summary>
        /// <param name="dictionary">The <see cref="T:System.Collections.Generic.IDictionary`2"/> whose elements are copied to the new <see cref="VirtualDictionary{TKey,TValue}"/>.</param><exception cref="T:System.ArgumentNullException"><paramref name="dictionary"/> is null.</exception><exception cref="T:System.ArgumentException"><paramref name="dictionary"/> contains one or more duplicate keys.</exception>
        public VirtualDictionary(IDictionary<TKey, TValue> dictionary)
        {
            wrappedDictionary = new Dictionary<TKey, TValue>(dictionary);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VirtualDictionary{TKey,TValue}"/> class that contains elements copied from the specified <see cref="T:System.Collections.Generic.IDictionary`2"/> and uses the specified <see cref="T:System.Collections.Generic.IEqualityComparer`1"/>.
        /// </summary>
        /// <param name="dictionary">The <see cref="T:System.Collections.Generic.IDictionary`2"/> whose elements are copied to the new <see cref="VirtualDictionary{TKey,TValue}"/>.</param><param name="comparer">The <see cref="T:System.Collections.Generic.IEqualityComparer`1"/> implementation to use when comparing keys, or null to use the default <see cref="T:System.Collections.Generic.EqualityComparer`1"/> for the type of the key.</param><exception cref="T:System.ArgumentNullException"><paramref name="dictionary"/> is null.</exception><exception cref="T:System.ArgumentException"><paramref name="dictionary"/> contains one or more duplicate keys.</exception>
        public VirtualDictionary(IDictionary<TKey, TValue> dictionary, IEqualityComparer<TKey> comparer)
        {
            wrappedDictionary = new Dictionary<TKey, TValue>(dictionary, comparer);
        }




        public TValue this[TKey key] { get => ((IDictionary<TKey, TValue>)wrappedDictionary)[key]; set => ((IDictionary<TKey, TValue>)wrappedDictionary)[key] = value; }

        public ICollection<TKey> Keys => ((IDictionary<TKey, TValue>)wrappedDictionary).Keys;

        public ICollection<TValue> Values => ((IDictionary<TKey, TValue>)wrappedDictionary).Values;

        [TypeConverter(typeof(ListConverter))]
        public List<TValue> ReadableValues => ((IDictionary<TKey, TValue>)wrappedDictionary).Values.ToList();

        public int Count => ((IDictionary<TKey, TValue>)wrappedDictionary).Count;

        public bool IsReadOnly => ((IDictionary<TKey, TValue>)wrappedDictionary).IsReadOnly;

        public void Add(TKey key, TValue value)
        {
            ((IDictionary<TKey, TValue>)wrappedDictionary).Add(key, value);
        }

        public void Add(KeyValuePair<TKey, TValue> item)
        {
            ((IDictionary<TKey, TValue>)wrappedDictionary).Add(item);
        }

        public void Clear()
        {
            ((IDictionary<TKey, TValue>)wrappedDictionary).Clear();
        }

        public bool Contains(KeyValuePair<TKey, TValue> item)
        {
            return ((IDictionary<TKey, TValue>)wrappedDictionary).Contains(item);
        }

        public bool ContainsKey(TKey key)
        {
            return ((IDictionary<TKey, TValue>)wrappedDictionary).ContainsKey(key);
        }

        public bool ContainsValue(TValue value)
        {
            return (wrappedDictionary).ContainsValue(value);
        }

        public void CopyTo(KeyValuePair<TKey, TValue>[] array, int arrayIndex)
        {
            ((IDictionary<TKey, TValue>)wrappedDictionary).CopyTo(array, arrayIndex);
        }

        public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
        {
            return ((IDictionary<TKey, TValue>)wrappedDictionary).GetEnumerator();
        }

        public bool Remove(TKey key)
        {
            return ((IDictionary<TKey, TValue>)wrappedDictionary).Remove(key);
        }

        public bool Remove(KeyValuePair<TKey, TValue> item)
        {
            return ((IDictionary<TKey, TValue>)wrappedDictionary).Remove(item);
        }

        public bool TryGetValue(TKey key, out TValue value)
        {
            return ((IDictionary<TKey, TValue>)wrappedDictionary).TryGetValue(key, out value);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IDictionary<TKey, TValue>)wrappedDictionary).GetEnumerator();
        }
    }
}