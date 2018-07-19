using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.IO
{
    //Unfinished

    public class CR2WLegacyReader : BinaryReader
    {
        public CR2WLegacyReader(string path)
            : base(new FileStream(path, FileMode.Open, FileAccess.Read), Encoding.ASCII, false)
        {
            Console.WriteLine("File:            {0}", path);
            BaseStream.Seek(0, SeekOrigin.Begin);
        }

        public void ReadAll()
        {
            var magic           = ReadUInt32();
            var version         = ReadUInt32();
            var flags           = ReadUInt32();
            var stringsoffset   = ReadUInt32();
            var stringscount    = ReadUInt32();
            var objectsoffset   = ReadUInt32();
            var objectscount    = ReadUInt32();
            var linkoffset      = ReadUInt32();
            var linkcount       = ReadUInt32();
            var dependencydata0 = ReadUInt32();
            var dependencycount = ReadUInt32();

            Console.WriteLine("Version:         {0}", version);
            Console.WriteLine("Flags:           {0}", flags);
            Console.WriteLine("StringOffset:    {0}", stringsoffset);
            Console.WriteLine("StringCount:     {0}", stringscount);
            Console.WriteLine("ObjectsOffset:   {0}", objectsoffset);
            Console.WriteLine("ObjectsCount:    {0}", objectscount);
            Console.WriteLine("LinkCount:       {0}", linkcount);
            Console.WriteLine("LinkOffset:      {0}", linkoffset);
            Console.WriteLine("DependencyData0: {0}", dependencydata0);
            Console.WriteLine("DependencyCount: {0}", dependencycount);

            Console.WriteLine();
            Console.WriteLine("Strings:");
            BaseStream.Seek(stringsoffset, SeekOrigin.Begin);
            for (uint i = 0; i < stringscount; i++)
            {
                var len = ReadVLQInt32();
                Console.WriteLine("\t{0}", Encoding.ASCII.GetString(ReadBytes(Math.Abs(len))));
            }

            Console.WriteLine();
            Console.WriteLine(BaseStream.Position);
            Console.WriteLine();
            //Console.WriteLine(Encoding.ASCII.GetString(ReadBytes(Convert.ToInt32(BaseStream.Length - BaseStream.Position))));







        }

        public int ReadVLQInt32()
        {
            var b1 = ReadByte();
            var sign = (b1 & 128) == 128;
            var next = (b1 & 64) == 64;
            var size = b1 % 128 % 64;
            var offset = 6;
            while (next)
            {
                var b = ReadByte();
                size = (b % 128) << offset | size;
                next = (b & 128) == 128;
                offset += 7;
            }
            size = sign ? size * -1 : size;
            return size;
        }
    }
}
