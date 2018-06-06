using System;
using System.IO;
using System.Text;
using CR2W.Attributes;
using CR2W.IO;

namespace CR2W.Testing
{
    public class ReflectionTesting
    {
        public static void RunTest()
        {
            var exporter = new CR2WExporter();
            var MainTester = new TestMain()
            {
                Prop1 = 5635374,
                Prop2 = 0.535f,
                Prop3 = -34,
                Prop4 = new SubTest1()
                {
                    Prop1 = -453435,
                    Prop2 = true,
                    Prop3 = 221,
                },
                Prop5 = new SubTest2()
                {
                    Prop1 = Guid.NewGuid(),
                    Prop2 = 55373564,
                    Prop3 = false,
                },

            };
            using (var mem = new MemoryStream())
            {
                using (var bw = new BinaryWriter(mem))
                {
                    new CR2WPropAttributeAttribute("_main", "TestMain").Serialize(MainTester, bw, exporter);
                }
                Console.WriteLine(Encoding.Default.GetString(mem.ToArray()));
            }
        }
    }

    class SubTest1
    {
        [Int32("_prop1")]
        public int Prop1 { get; set; }

        [Bool("_prop2")]
        public bool Prop2 { get; set; }

        [Uint8("_prop3")]
        public byte Prop3 { get; set; }
    }

    class SubTest2
    {
        [CGUID("_prop1")]
        public Guid Prop1 { get; set; }

        [LocString("_prop2")]
        public uint Prop2 { get; set; }

        [Bool("_prop3")]
        public bool Prop3 { get; set; }
    }

    class TestMain
    {
        [Uint32("_prop1")]
        public uint Prop1 { get; set; }

        [Float("_prop2")]
        public float Prop2 { get; set; }

        [Int8("_prop3")]
        public sbyte Prop3 { get; set; }

        [CR2WPropAttribute("_prop4", "SubTest1")]
        public SubTest1 Prop4 { get; set; }

        [CR2WPropAttribute("_prop4", "SubTest2")]
        public SubTest2 Prop5 { get; set; }
    }
}