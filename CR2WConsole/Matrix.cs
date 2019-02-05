using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CR2WConsole
{
    /// <summary>
    /// Represents a strongly typed 2-dimensional matrix of objects that can be accessed by index, or row and collumn. 
    /// Provides methods to add, remove, insert rows or collumns.
    /// </summary>
    /// <typeparam name="T">The type of elements in the matrix.</typeparam>
    public class Matrix<T> : IEquatable<Matrix<T>>
    {
        private T[,] m_items;
        private readonly static T[,] m_empty = new T[0,0];

        public int Height
        {
            get
            {
                return m_items.GetLength(0);
            }
        }
        public int Width
        {
            get
            {
                return m_items.GetLength(1);
            }
        }
        public int Length
        {
            get
            {
                return m_items.Length;
            }
        }

        public T this[int index]
        {
            get
            {
                var row = Math.DivRem(index, Width, out var collumn);
                return m_items[row, collumn];
            }
            set
            {
                var row = Math.DivRem(index, Width, out var collumn);
                m_items[row, collumn] = value;
            }
        }
        public T this[int row, int collumn]
        {
            get
            {
                return m_items[row, collumn];
            }
            set
            {
                m_items[row, collumn] = value;
            }
        }

        public Matrix()
        {
            m_items = m_empty;
        }
        public Matrix(int height, int width)
        {
            m_items = new T[height,width];
        }
        public Matrix(T[,] items)
        {
            m_items = new T[items.GetLength(0), items.GetLength(1)];
            Array.Copy(items, m_items, items.Length);
        }

        public void Resize(int newHeight, int newWidth)
        {
            var newArray = new T[newHeight, newWidth];
            var minWidth = Math.Min(this.Width, newWidth);
            var minHeight = Math.Min(this.Height, newHeight);
            for (int i = 0; i < minHeight; i++)
            {
                Array.Copy(m_items, checked(i * Width), newArray, checked(i * newWidth), minWidth);
            }
            m_items = newArray;
        }

        public void AddRow()
        {
            var newArray = new T[Height + 1, Width];
            Array.Copy(m_items, newArray, Length);
            m_items = newArray;
        }
        public void AddRow(T[] rowItems)
        {
            AddRow();
            var minWidth = Math.Min(Width, rowItems.Length);
            for (int x = 0; x < minWidth; x++)
            {
                m_items[Height - 1, x] = rowItems[x];
            }
        }
        public void RemoveRow()
        {
            var newArray = new T[Height - 1, Width];
            Array.Copy(m_items, newArray, newArray.Length);
            m_items = newArray;
        }
        public void RemoveRow(int rowIndex)
        {
            var newArray = new T[Height - 1, Width];
            Array.Copy(m_items, 0, newArray, 0, checked(rowIndex * Width));
            Array.Copy(m_items, checked((rowIndex + 1) * Width), newArray, checked(rowIndex * Width), checked(newArray.Length - Width * rowIndex));
            m_items = newArray;
        }
        public void InsertRow(int rowIndex)
        {
            var newArray = new T[Height + 1, Width];
            Array.Copy(m_items, 0, newArray, 0, checked(rowIndex * Width));
            Array.Copy(m_items, checked(rowIndex * Width), newArray, checked((rowIndex + 1) * Width), checked(newArray.Length - (rowIndex + 1) * Width));
            m_items = newArray;
        }
        public void InsertRow(T[] rowItems, int rowIndex)
        {
            InsertRow(rowIndex);
            var minWidth = Math.Min(rowItems.Length, Width);
            for (int x = 0; x < minWidth; x++)
            {
                m_items[rowIndex, x] = rowItems[x];
            }
        }

        public void AddCollumn()
        {
            var newArray = new T[Height, Width + 1];
            for (int y = 0; y < Height; y++)
            {
                Array.Copy(m_items, checked(Width * y), newArray, checked((Width + 1) * y), Width);
            }
            m_items = newArray;
        }
        public void AddCollumn(T[] collumnItems)
        {
            AddCollumn();
            var height = Math.Min(collumnItems.Length, Height);
            for (int y = 0; y < height; y++)
            {
                m_items[y, Width - 1] = collumnItems[y];
            }
        }
        public void RemoveCollumn()
        {
            var newArray = new T[Height, Width - 1];
            for (int y = 0; y < Height; y++)
            {
                Array.Copy(m_items, checked(Width * y), newArray, checked((Width - 1) * y), Width - 1);
            }
            m_items = newArray;
        }
        public void RemoveCollumn(int collumnIndex)
        {
            var newArray = new T[Height, Width - 1];
            for (int y = 0; y < Height; y++)
            {
                Array.Copy(m_items, checked(Width * y), newArray, checked(y * (Width - 1)), collumnIndex);
                Array.Copy(m_items, checked(y * Width + collumnIndex + 1), newArray, checked(y * (Width - 1) + collumnIndex), Width - collumnIndex - 1);
            }
            m_items = newArray;
        }
        public void InsertCollumn(int collumnIndex)
        {
            var newArray = new T[Height, Width + 1];
            for (int y = 0; y < Height; y++)
            {
                Array.Copy(m_items, checked(y * Width), newArray, checked(y * (Width + 1)), collumnIndex);
                Array.Copy(m_items, checked(y * Width + collumnIndex), newArray, checked(y * (Width + 1) + collumnIndex + 1), Width - collumnIndex);
            }
            m_items = newArray;
        }
        public void InsertCollumn(T[] collumnItems, int collumnIndex)
        {
            InsertCollumn(collumnIndex);
            var minHeight = Math.Min(collumnItems.Length, Height);
            for (int y = 0; y < minHeight; y++)
            {
                m_items[y, collumnIndex] = collumnItems[y];
            }
        }

        public T[,] ToArray()
        {
            var outArray = new T[Height, Width];
            Array.Copy(m_items, outArray, Length);
            return m_items;
        }

        public bool Equals(Matrix<T> other)
        {
            if (other is null)
                return false;

            if (ReferenceEquals(this.m_items, other.m_items))
                return true;

            if (this.Height != other.Height || this.Width != other.Width)
                return false;

            var comparer = EqualityComparer<T>.Default;
            for (int y = 0; y < Height; y++)
            {
                for (int x = 0; x < Width; x++)
                {
                    if (!comparer.Equals(this[y, x], other[y, x]))
                        return false;
                }
            }

            return true;
        }
        public override bool Equals(object obj)
        {
            if (obj is Matrix<T> m)
                return this.Equals(m);

            return false;
        }
        public override int GetHashCode()
        {
            return RuntimeHelpers.GetHashCode(this);
        }
        public override string ToString()
        {
            return string.Format("{0}<{1},{2}>", typeof(T).Name, Height, Width);
        }
    }
}
