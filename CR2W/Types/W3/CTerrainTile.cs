using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CR2W.IO;

namespace CR2W.Types.W3
{
    class CTerrainTile : CResource
    {
        UInt32 TileFileVersion { get; set; }
        ETerrainTileCollision CollisionType { get; set; }
        UInt16 MaxHeightValue { get; set; }
        UInt16 MinHeightValue { get; set; }

        public override void ParseBytes(CR2WBinaryReader br, uint size)
        {
            base.ParseBytes(br, size);

            /* - TODO parse the bytes in the buffers
             *        That block 6 point to.
             */

        }
    }
}
