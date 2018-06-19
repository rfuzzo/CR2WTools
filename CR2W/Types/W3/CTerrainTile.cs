using System;
using CR2W.IO;
using CR2W.Attributes;

namespace CR2W.Types.W3
{
    class CTerrainTile : CResource
    {
        [W3Type("tileFileVersion")]
        UInt32 TileFileVersion { get; set; }

        [W3Type("collisionType")]
        ETerrainTileCollision CollisionType { get; set; }

        [W3Type("maxHeightValue")]
        UInt16 MaxHeightValue { get; set; }

        [W3Type("minHeightValue")]
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
