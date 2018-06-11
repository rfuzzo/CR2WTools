using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CR2W.IO;

namespace CR2W.Types.W3
{
    public class C2dArray : CResource
    {
        public CArray<string> Headers { get; set; }
        public CArray<CArray<string>> Data { get; set; }

        public string GetValueAt(int collumn, int row)
        {
            return Data[row][collumn];
        }

        public string GetValue(string header, int row)
        {
            var id = Headers.IndexOf(header);
            return Data[row][id];
        }

        public int GetNumRows()
        {
            return Data.Count;
        }

        public int GetRowIndexAt(int collumn, string value)
        {
            for (int row = 0; row < Data.Count; row++)
            {
                if(Data[row][collumn] == value)
                {
                    return row;
                }
            }
            return -1;
        }

        public int GetRowIndex(string header, string value)
        {
            var collumn = Headers.IndexOf(header);
            return GetRowIndexAt(collumn, value);
        }

        public void SetValue( int row, int collumn, string value )
        {
            Data[row][collumn] = value;
        }

        public void SetValue( string header, int row, string value )
        {
            var collumn = Headers.IndexOf(header);
            SetValue(row, collumn, value);
        }
    }
}
