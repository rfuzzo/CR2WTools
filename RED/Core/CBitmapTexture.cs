using RED.CR2W;
using RED.Reflection;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;

namespace RED.Core
{
    public class CBitmapTexture : ITexture
    {
        #region RED Fields
        [RED] private protected uint width;
        [RED] private protected uint height;
        [RED] private protected ETextureRawFormat format;
        [RED] private protected ETextureCompression compression;
        [RED] private protected Handle<CSourceTexture> sourceData;
        [RED] private protected CName textureGroup;
        [RED] private protected int pcDownscaleBias;
        [RED] private protected int xboneDownscaleBias;
        [RED] private protected int ps4DownscaleBias;
        [RED] private protected byte residentMipIndex;
        [RED] private protected uint textureCacheKey;
        #endregion

        private Bitmap m_texture;

        public virtual uint Width
        {
            get => width;
            set => width = value;
        }
        public virtual uint Height
        {
            get => height;
            set => height = value;
        }
        public virtual ETextureRawFormat Format
        {
            get => format;
            set => format = value;
        }
        public virtual ETextureCompression Compression
        {
            get => compression;
            set => compression = value;
        }
        public virtual Handle<CSourceTexture> SourceData
        {
            get => sourceData;
            set => sourceData = value;
        }
        public virtual CName TextureGroup
        {
            get => textureGroup;
            set => textureGroup = value;
        }
        public virtual int PCDownscaleBias
        {
            get => pcDownscaleBias;
            set => pcDownscaleBias = value;
        }
        public virtual int XBoneDownscaleBias
        {
            get => xboneDownscaleBias;
            set => xboneDownscaleBias = value;
        }
        public virtual int PS4DownscaleBias
        {
            get => ps4DownscaleBias;
            set => ps4DownscaleBias = value;
        }
        public virtual byte ResidentMipIndex
        {
            get => residentMipIndex;
            set => residentMipIndex = value;
        }
        public virtual uint TextureCacheKey
        {
            get => textureCacheKey;
            set => textureCacheKey = value;
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