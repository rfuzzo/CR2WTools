﻿using System;
using System.IO;
using System.Drawing;
using CR2W.IO;
using CR2W.DDS.Utils;
using CR2W.DDS;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;

namespace CR2W.Types.W3
{
    struct SBitmapTextureDataHeader
    {
        //This value is always 0 as far as I can tell.
        public uint unknown1;

        //Value is any of the following:
        //9 11 8 4 12 10 6 5 7 2 13 1
        //Values were taken from a dump of most xbm files in the game.
        public uint unknown2;

        public uint width;
        public uint height;

        //Value is any of the following:
        //512 256 128 1024 2048 4096 16 8192 32 64 8 16384
        public uint unknown5;

        public uint sizeorpitch;

        //No idea - has huge variation from file to file.
        public uint unknown7;
    }

    public class CBitmapTexture : CResource, ITexture
    {
        [REDProp("width")]
        public uint Width { get; set; }

        [REDProp("height")]
        public uint Height { get; set; }

        [REDProp("format")]
        public ETextureRawFormat Format { get; set; }

        [REDProp("compression")]
        public ETextureCompression Compression { get; set; }

        [REDProp("sourceData")]
        public Handle<CSourceTexture> SourceData { get; set; }

        [REDProp("textureGroup")]
        public CName TextureGroup { get; set; }
        /*  - All possible options.
         *  
         *  BillboardAtlas
         *  CharacterDiffuse
         *  CharacterDiffuseWithAlpha
         *  CharacterEmissive
         *  CharacterNormal
         *  CharacterNormalHQ
         *  CharacterNormalmapGloss
         *  Default
         *  DetailNormalMap
         *  DiffuseNoMips
         *  Flares
         *  FoliageDiffuse
         *  Font
         *  GUIWithAlpha
         *  GUIWithoutAlpha
         *  HeadDiffuse
         *  HeadDiffuseWithAlpha
         *  HeadEmissive
         *  HeadNormal
         *  HeadNormalHQ
         *  MimicDecalsNormal
         *  NormalmapGloss
         *  NormalsNoMips
         *  Particles
         *  ParticlesWithoutAlpha
         *  PostFxMap
         *  QualityColor
         *  QualityOneChannel
         *  QualityTwoChannels
         *  SpecialQuestDiffuse
         *  SpecialQuestNormal
         *  SystemNoMips
         *  TerrainDiffuse
         *  TerrainNormal
         *  WorldDiffuse
         *  WorldDiffuseWithAlpha
         *  WorldEmissive
         *  WorldNormal
         *  WorldNormalHQ
         *  WorldSpecular
         */

        [REDProp("pcDownscaleBias")]
        public int PCDownscaleBias { get; set; }

        [REDProp("xboneDownscaleBias")]
        public int XBoneDownscaleBias { get; set; }

        [REDProp("ps4DownscaleBias")]
        public int PS4DownscaleBias { get; set; }

        [REDProp("residentMipIndex")]
        public byte ResidentMipIndex { get; set; }

        [REDProp("textureCacheKey")]
        public uint TextureCacheKey { get; set; }

        public Bitmap TextureMap { get; set; }

        public override void ParseBytes(CR2WBinaryReader br, uint size)
        {
            var pos = br.BaseStream.Position;
            base.ParseBytes(br, size);

            /*
             *  This is a temporary solution for reading the contents of a CBitmapTexture
             *  What this does is contruct a dds header object and parse it and the raw bytes 
             *  using the dds library.
             *  
             *  The bitmap bytes from the cr2w has a header 28 bytes long, containing data about the 
             *  image such as size and height etc...
             *  There are 4 unknown ones.
             *  
             *  This class should in the end support reading all xbm files with means supporting not just 
             *  dds but tga, bmp, png, and jpg.
             * 
             */

            var cbmheader = new SBitmapTextureDataHeader()
            {
                unknown1    = br.ReadUInt32(),
                unknown2    = br.ReadUInt32(),
                width       = br.ReadUInt32(),
                height      = br.ReadUInt32(),
                unknown5    = br.ReadUInt32(),
                sizeorpitch = br.ReadUInt32(),
                unknown7    = br.ReadUInt32(),
            };

            var ddsheader = new DDSStruct
            {
                size            = 124,
                flags           = 659463,
                width           = cbmheader.width,
                height          = cbmheader.height,
                sizeorpitch     = cbmheader.sizeorpitch,
                depth           = 1,
                mipmapcount     = 1,
                reserved        = new uint[10],
            };
            ddsheader.ddscaps.caps1 = 4096;
            ddsheader.pixelformat.flags = 5;
            ddsheader.pixelformat.size = 32;
            ddsheader.pixelformat.fourcc = DDS.Utils.Helper.FOURCC_DXT5;

            //switch (Compression)
            //{
            //    case ETextureCompression.TCM_DXTAlpha:
            //    case ETextureCompression.TCM_DXTAlphaLinear:
            //    case ETextureCompression.TCM_None:
            //    case ETextureCompression.TCM_Normals:
            //    case ETextureCompression.TCM_NormalsGloss:
            //    case ETextureCompression.TCM_NormalsHigh:
            //    case ETextureCompression.TCM_QualityR:
            //    case ETextureCompression.TCM_QualityRG:
            //    case ETextureCompression.TCM_RGBE:
            //    case ETextureCompression.TCM_QualityColor:
            //        ddsheader.pixelformat.fourcc = DDS.Utils.Helper.FOURCC_DXT5;
            //        break;
            //    case ETextureCompression.TCM_DXTNoAlpha:
            //        ddsheader.pixelformat.fourcc = DDS.Utils.Helper.FOURCC_DXT1;
            //        break;
            //}

            var rawsize = Convert.ToInt32(pos + size - br.BaseStream.Position);
            var raw = br.ReadBytes(rawsize);
            var dds = new DDSImage(raw, ddsheader, true);

            Form form = new Form
            {
                Text = "Image"
            };
            PictureBox pictureBox = new PictureBox
            {
                Image = dds.BitmapImage,
                Width = (int)ddsheader.width,
                Height = (int)ddsheader.height
            };
            form.Controls.Add(pictureBox);
            var t = new Task(() => 
            {
                Application.Run(form);
            });
            t.Start();
        }

        public List<TexEncodePair> TEX_ENCODE_PAIRS = new List<TexEncodePair>()
        {
            new TexEncodePair(){code = 0x3FD, format = ETextureFormat.TEXFMT_R8G8B8A8},
            new TexEncodePair(){code = 0x40B, format = ETextureFormat.TEXFMT_Float_R16G16B16A16},
            new TexEncodePair(){code = 0x40C, format = ETextureFormat.TEXFMT_Float_R32G32B32A32},
            new TexEncodePair(){code = 0x407, format = ETextureFormat.TEXFMT_BC1},
            new TexEncodePair(){code = 0x40D, format = ETextureFormat.TEXFMT_BC2},
            new TexEncodePair(){code = 0x408, format = ETextureFormat.TEXFMT_BC3},
            new TexEncodePair(){code = 0x40E, format = ETextureFormat.TEXFMT_BC4},
            new TexEncodePair(){code = 0x40F, format = ETextureFormat.TEXFMT_BC5},
            new TexEncodePair(){code = 0x409, format = ETextureFormat.TEXFMT_BC6H},
            new TexEncodePair(){code = 0x40A, format = ETextureFormat.TEXFMT_BC7},
        };

        ETextureFormat DecodeTextureFormat(Int16 encoded)
        {
            return TEX_ENCODE_PAIRS.First(t => t.code == encoded).format;
        }

        public struct TexEncodePair
        {
            public UInt16 code;
            public ETextureFormat format;
        };

        public enum ETextureFormat
        {
            TEXFMT_A8 = 0x0,
            TEXFMT_A8_Scaleform = 0x1,
            TEXFMT_L8 = 0x2,
            TEXFMT_R8G8B8X8 = 0x3,
            TEXFMT_R8G8B8A8 = 0x4,
            TEXFMT_A8L8 = 0x5,
            TEXFMT_Uint_16_norm = 0x6,
            TEXFMT_Uint_16 = 0x7,
            TEXFMT_Uint_32 = 0x8,
            TEXFMT_R32G32_Uint = 0x9,
            TEXFMT_R16G16_Uint = 0xA,
            TEXFMT_Float_R10G10B10A2 = 0xB,
            TEXFMT_Float_R16G16B16A16 = 0xC,
            TEXFMT_Float_R11G11B10 = 0xD,
            TEXFMT_Float_R16G16 = 0xE,
            TEXFMT_Float_R32G32 = 0xF,
            TEXFMT_Float_R32G32B32A32 = 0x10,
            TEXFMT_Float_R32 = 0x11,
            TEXFMT_Float_R16 = 0x12,
            TEXFMT_D24S8 = 0x13,
            TEXFMT_D24FS8 = 0x14,
            TEXFMT_D32F = 0x15,
            TEXFMT_D16U = 0x16,
            TEXFMT_BC1 = 0x17,
            TEXFMT_BC2 = 0x18,
            TEXFMT_BC3 = 0x19,
            TEXFMT_BC4 = 0x1A,
            TEXFMT_BC5 = 0x1B,
            TEXFMT_BC6H = 0x1C,
            TEXFMT_BC7 = 0x1D,
            TEXFMT_R8_Uint = 0x1E,
            TEXFMT_NULL = 0x1F,
            TEXFMT_Max = 0x20,
        };
    }


}