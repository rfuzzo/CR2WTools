using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections.ObjectModel;
using RED.CR2W;
using System.Collections.Specialized;
using System.Reflection;
using System.Collections;
using System.ComponentModel;

namespace RED
{
    /*
     *  This is a (almost) copy of the .NET list class but uses a fixed buffer size for expanding, 
     *  and is suitable for overriding functions for adding, removing and replacing members.
     * 
     *  This is also possible to expand in the future, with stuff like INotifyCollectionChanged etc...
     * 
     */

    /// <summary>
    /// Represents a strongly typed dynamic array of objects designed for REDEnegine arrays.
    /// Provides methods to add, and remove items.
    /// Memory is allocated in blocks equal to the buffer size.
    /// </summary>
    /// <typeparam name="T">The type of object in the array.</typeparam>
    public class TDynArray<T> : IList<T>, IReadOnlyList<T>, IEnumerable<T>, IEnumerable
    {
        #region Fields
        private T[]             m_items;
        private int             m_size;
        private readonly int    m_bufferSize;
        private readonly bool   m_isReadOnly;
        private const int       DefaultBufferSzie = 2;
        #endregion

        #region Properties
        public T this[int index]
        {
            get
            {
                if (index < 0 || index >= Count)
                {
                    throw new IndexOutOfRangeException();
                }
                return m_items[index];
            }
            set
            {
                if(IsReadOnly)
                {
                    throw new NotSupportedException();
                }
                if (index < 0 || index >= Count)
                {
                    throw new IndexOutOfRangeException();
                }
                SetItem(index, value);
            }
        }

        public int Capacity
        {
            get
            {
                return m_items.Length;
            }
            set
            {
                EnsureCapacity(value);
            }
        }
        public int Count
        {
            get
            {
                return m_size;
            }
        }
        public bool IsReadOnly
        {
            get
            {
                return m_isReadOnly;
            }
        }
        public int BufferSize
        {
            get
            {
                return m_bufferSize;
            }
        }
        #endregion

        #region Constructors
        public TDynArray()
            : this(DefaultBufferSzie, false)
        {

        }
        public TDynArray(int bufferSize)
            : this(bufferSize, false)
        {

        }
        public TDynArray(IEnumerable<T> items)
            : this(items, DefaultBufferSzie, false)
        {

        }
        public TDynArray(IEnumerable<T> items, bool isReadOnly) 
            : this(items, DefaultBufferSzie, isReadOnly)
        {
            
        }
        public TDynArray(IEnumerable<T> items, int bufferSize, bool isReadOnly) 
            : this(bufferSize, isReadOnly)
        {
            using (var e = items.GetEnumerator())
            {
                while (e.MoveNext())
                {
                    m_size++;
                }
                e.Reset();
                Capacity = m_size;
                var index = 0;
                while (e.MoveNext())
                {
                    m_items[index++] = e.Current;
                }
            }
        }
        public TDynArray(int bufferSize, bool isReadOnly)
        {
            m_bufferSize = bufferSize;
            m_size = 0;
            m_isReadOnly = isReadOnly;
            m_items = Array.Empty<T>();
        }
        #endregion

        #region Public
        public void Add(T item)
        {
            if (IsReadOnly)
            {
                throw new NotSupportedException();
            }
            InsertItem(Count, item);
        }
        public bool Remove(T item)
        {
            if (IsReadOnly)
            {
                throw new NotSupportedException();
            }
            var index = Array.IndexOf(m_items, item);
            if (index < 0)
            {
                return false;
            }
            RemoveItem(index);
            return true;
        }
        public void RemoveAt(int index)
        {
            if (IsReadOnly)
            {
                throw new NotSupportedException();
            }
            if (index < 0 || index > Count)
            {
                throw new IndexOutOfRangeException();
            }
            RemoveItem(index);
        }
        public void Clear()
        {
            if (IsReadOnly)
            {
                throw new NotSupportedException();
            }
            ClearItems();
        }
        public bool Contains(T item)
        {
            var comparer = EqualityComparer<T>.Default;
            return Contains(item, comparer);
        }
        public bool Contains(T item, IEqualityComparer<T> comparer)
        {
            if(comparer is null)
            {
                throw new ArgumentNullException(nameof(comparer));
            }
            for (int i = 0; i < Count; i++)
            {
                if (comparer.Equals(m_items[i], item))
                {
                    return true;
                }
            }
            return false;
        }
        public void Insert(int index, T item)
        {
            if (IsReadOnly)
            {
                throw new NotSupportedException();
            }
            if (index < 0 || index > Count)
            {
                throw new IndexOutOfRangeException();
            }
            InsertItem(index, item);
        }
        public void CopyTo(T[] array, int arrayIndex)
        {
            Array.Copy(m_items, 0, array, arrayIndex, Count);
        }
        public int IndexOf(T item)
        {
            return Array.IndexOf(m_items, item, 0, Count);
        }
        #endregion

        #region Protected Virtual
        protected virtual void ClearItems()
        {
            Array.Clear(m_items, 0, Count);
        }
        protected virtual void RemoveItem(int index)
        {
            m_size--;
            if (index < m_size)
            {
                Array.Copy(m_items, index + 1, m_items, index, m_size - index);
            }
            m_items[m_size] = default;
            Capacity = m_size;
        }
        protected virtual void InsertItem(int index, T item)
        {
            if(m_size == Capacity)
            {
                Capacity++;
            }
            if (index < m_size)
            {
                Array.Copy(m_items, index, m_items, index + 1, m_size - index);
            }
            m_items[index] = item;
            m_size++;
        }
        protected virtual void SetItem(int index, T item)
        {
            m_items[index] = item;
        }
        #endregion

        #region Enumerator
        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < Count; i++)
            {
                yield return m_items[i];
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        #endregion

        private void EnsureCapacity(int capacity)
        {
            if(capacity < m_size)
            {
                throw new IndexOutOfRangeException();
            }
            var actualSize = RoundUpToBufferStep(capacity);
            if(actualSize == Capacity)
            {
                return;
            }
            Array.Resize(ref m_items, actualSize);
        }
        private int RoundUpToBufferStep(int capacity)
        {
            if (capacity % m_bufferSize == 0)
            {
                return capacity;
            }
            return (m_bufferSize - capacity % m_bufferSize) + capacity;
        }

        public override string ToString()
        {
            return String.Format("{0}[{1},{2},{3}]", nameof(TDynArray<T>), typeof(T).Name, Count, Capacity);
        }
        public T[] ToArray()
        {
            var outArray = new T[Count];
            Array.Copy(m_items, outArray, Count);
            return outArray;
        }
    }
}