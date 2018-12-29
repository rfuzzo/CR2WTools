using System;
using System.Drawing;
using System.ComponentModel;
using System.Windows.Forms;
using CR2W.DDS;
using CR2W.DDS.Utils;
using CR2W.IO;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
    [TypeConverter(typeof(ExpandableObjectConverter))]public class CSwfTexture : CBitmapTexture
    {
        [REDProp("linkageName")]
        public string LinkageName { get; set; }

        public override void ParseBytes(CR2WBinaryReader br, uint size)
        {
            base.ParseClass(br, this);

            var zero        = br.ReadUInt32();
            var mipCount    = br.ReadUInt32();
            var width       = br.ReadUInt32();
            var height      = br.ReadUInt32();
            var unknown5    = br.ReadUInt32();
            var sizeorpitch = br.ReadUInt32();
            //var unknown7    = br.ReadUInt32();

            Console.WriteLine("zero        {0}", zero);
            Console.WriteLine("mipCount    {0}", mipCount);
            Console.WriteLine("width       {0}", width);
            Console.WriteLine("height      {0}", height);
            Console.WriteLine("unknown5    {0}", unknown5);
            Console.WriteLine("sizeorpitch {0}", sizeorpitch);
            //Console.WriteLine("unknown7    {0}", sizeorpitch);

            var ddsheader = new DDSStruct
            {
                size = 124,
                flags = 659463,
                width = width,
                height = height,
                sizeorpitch = sizeorpitch,
                depth = 1,
                mipmapcount = 1,
                reserved = new uint[10],
            };

            ddsheader.ddscaps.caps1 = 4096;
            ddsheader.pixelformat.size = 32;
            ddsheader.pixelformat.flags = 5;
            ddsheader.pixelformat.fourcc = DDSHelper.FOURCC_DXT1;

            var dds = new DDSImage(br, ddsheader, true);

            Form form = new Form
            {
                Text = LinkageName,
                ClientSize = new Size((int)width, (int)height),
            };
            PictureBox pictureBox = new PictureBox
            {
                Image = dds.BitmapImage,
                Width = (int)width,
                Height = (int)height
            };
            form.Controls.Add(pictureBox);
            var t = new Task(() =>
            {
                Application.Run(form);
            });
            t.Start();
        }

    }
}
