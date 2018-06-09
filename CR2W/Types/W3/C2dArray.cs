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
        public CArray<string>         Headers { get; set; }
        public CArray<CArray<string>> Data { get; set; }

        public string GetValueAt(int collumn, int row)
        {
            throw new NotImplementedException();
        }

        public string GetValue(string header, int row)
        {
            throw new NotImplementedException();
        }

        public string GetNumRows()
        {
            throw new NotImplementedException();
        }

        public string GetRowIndexAt(int collumn, string value)
        {
            throw new NotImplementedException();
        }

        public string GetRowIndex(string header, string value)
        {
            throw new NotImplementedException();
        }
    }
}
