using RED;
using RED.Core;
using RED.CR2W;
using RED.CR2W.Utils;
using RED.DDS.Utils;
using RED.Reflection;
using RED.Utilities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Xml.Serialization;
using System.Xml;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Globalization;
using System.Runtime.Serialization;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace CR2WConsole
{
    public class Program
    {
        static readonly ReadOnlyCollection<string> Extenstions = new ReadOnlyCollection<string>(new string[]
        {
            ".w2anims",
            ".w2rig",
            ".w2ent",
            ".w2beh",
            ".w3dyng",
            ".w2cutscene",
            ".w2mg",
            ".w2p",
            ".xbm",
            ".w2ragdoll",
            ".w2mesh",
            ".redfur",
            ".redcloth",
            ".w3fac",
            ".w2mi",
            ".w2cube",
            ".texarray",
            ".w2cent",
            ".redgame",
            ".w2fnt",
            ".redswf",
            ".redapex",
            ".env",
            ".w2am",
            ".w2em",
            ".w2qm",
            ".formation",
            ".w2steer",
            ".w2job",
            ".w2comm",
            ".w2scene",
            ".w2phase",
            ".redicsv",
            ".hud",
            ".menu",
            ".guiconfig",
            ".popup",
            ".w2je",
            ".journal",
            ".w2behtree",
            ".w2quest",
            ".w2animev",
            ".vbrush",
            ".w2sf",
            ".w2l",
            ".grassmask",
            ".w2w",
            ".w3simplex",
            ".cellmap",
            ".redexp",
            ".redwpset",
            ".w3occlusion",
            ".flyr",
            ".w2ter",
            ".spawntree",
            ".wizdef",
            ".reddest",
            ".w2dset",
            ".reddlc",
            ".w3app"
        });

        [STAThread]
        static unsafe int Main(string[] args)
        {
            //SelectFile(true);
            //TestWriter()
            //ScallAll();

            return 0;
        }

        static void SelectFile(bool test = true)
        {
            try
            {
                using (var of = new OpenFileDialog())
                {
                    if (of.ShowDialog() == DialogResult.OK)
                    {
                        if(test)
                        {
                            //TestStringsReader(of.FileName);
                            TestFile(of.FileName);
                            //CResourceManager.LoadCSV(of.FileName);
                        }
                        else
                        {
                            OpenFile(of.FileName);
                        }
                    }
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public static IEnumerable<FileInfo> GetFilesByExtensions(DirectoryInfo dirInfo, IEnumerable<string> extensions)
        {
            var allowedExtensions = new HashSet<string>(extensions, StringComparer.OrdinalIgnoreCase);

            return dirInfo.EnumerateFiles("*.*", SearchOption.AllDirectories).Where(f => allowedExtensions.Contains(f.Extension));
        }

        static void ScallAll()
        {
            var dir = new DirectoryInfo(@"D:\GOG\The_Witcher_3_Wild_Hunt_GOTY\r4data");

            var files = GetFilesByExtensions(dir, Extenstions);

            foreach (var file in files)
            {
                Console.Title = file.Name;
                try
                {
                    TestFile(file.FullName);
                }
                catch(InvalidCR2WFileException)
                {
                    continue;
                }
                catch(Exception)
                {
                    //Console.WriteLine("{0}\n\t{1}\n", file.FullName, e.Message);
                    continue;
                }
            }
        }

        static void TestFile(string path)
        {
            using (var br = new CR2WTestReader(path, Console.Out))
            {
                br.ReadAll();
            }
        }

        static void TestStringsReader(string path)
        {
            using (var fs = new FileStream(path, FileMode.Open, FileAccess.Read))
            using (var sr = new StringsReader(fs))
            {

            }
        }

        static void OpenFile(string path)
        {
            Console.WriteLine(path);
            using(var fs = new FileStream(path, FileMode.Open, FileAccess.Read))
            using (var br = new CR2WReader(fs, false))
            {

            }
        }

        static void TestWriter()
        {
            var mem = new FileStream(@"D:\ModKit\testing_workspace\dumptests\files\block4test.CR2W", FileMode.Create, FileAccess.ReadWrite);

            var bw = new CR2WWriter(mem);
            bw.Serialize();

            //bw.Dispose();

            var br = new CR2WTestReader(mem, Console.Out);
            br.ReadAll();
        }
    }

    public class DebugOut : TextWriter
    {
        public override Encoding Encoding => Encoding.ASCII;
    }
}