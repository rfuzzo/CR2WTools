using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using RED.CR2W;

namespace RED
{
    [StructLayout(LayoutKind.Sequential)]
    public struct LocalizedString
    {
        private uint _idKey;

        public uint IdKey
        {
            get => _idKey;
            set => _idKey = value;
        }

        public LocalizedString(uint id)
        {
            _idKey = id;
        }

        public string GetText()
        {
            throw new NotImplementedException();
        }
    }
}