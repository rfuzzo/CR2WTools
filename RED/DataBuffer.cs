using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using RED.CR2W;

namespace RED
{
    /// <summary>
    /// Represents an enumerable byte array buffer of a fixed size.
    /// </summary>
    public class DataBuffer
    {
        private byte[] m_data;

        public int Size
        {
            get
            {
                return m_data.Length;
            }
        }

        public DataBuffer()
        {
            m_data = Array.Empty<byte>();
        }
        public DataBuffer(int size)
        {
            m_data = new byte[size];
        }
        public DataBuffer(byte[] data)
        {
            m_data = new byte[data.Length];
            Array.Copy(data, 0, m_data, 0, data.Length);
        }

        public byte this[int index]
        {
            get
            {
                return m_data[index];
            }
            set
            {
                m_data[index] = value;
            }
        }
    }
}