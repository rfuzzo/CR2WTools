using System;
using System.IO;
using System.Text;
using RED.CR2W;

namespace RED.Core
{
    public class CSourceTexture : CResource
    {
        #region RED Fields
        [RED] protected UInt32 width;
        [RED] protected UInt32 height;
        [RED] protected UInt32 pitch;
        [RED] protected ETextureRawFormat format;
        #endregion

        public UInt32 Width
        {
            get => width;
            set => width = value;
        }
        public UInt32 Height
        {
            get => width;
            set => width = value;
        }
        public UInt32 Pitch
        {
            get => pitch;
            set => pitch = value;
        }
        public ETextureRawFormat Format
        {
            get => format;
            set => format = value;
        }
    }
}