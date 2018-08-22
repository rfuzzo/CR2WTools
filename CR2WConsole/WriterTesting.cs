using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CR2W.IO;

namespace CR2WConsole
{
    public static class WriterTesting
    {
        public static void Test()
        {
            var mem = new MemoryStream();
            var bw = new CR2WBinaryWriter(mem);
            

            bw.WriteAll();

            using (var br = new CR2WTestReader(mem.ToArray(), Console.Out))
            {
                br.ReadAll();
            }

            File.WriteAllBytes(@"D:\ModKit\modkit_tools\testdump\files\testcube_uncooked.w2cube", mem.ToArray());

            bw.Dispose();
            mem.Dispose();
        }
    }
}
