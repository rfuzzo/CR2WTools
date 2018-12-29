using System;
using CR2W.IO;


namespace CR2W.Types.W3
{
    public class CTerrainTile : CResource
    {
        [REDProp("tileFileVersion")]
        public UInt32 TileFileVersion { get; set; }

        [REDProp("collisionType")]
        public ETerrainTileCollision CollisionType { get; set; }

        [REDProp("maxHeightValue")]
        public UInt16 MaxHeightValue { get; set; }

        [REDProp("minHeightValue")]
        public UInt16 MinHeightValue { get; set; }

        public override void ParseBytes(CR2WBinaryReader br, uint size)
        {
            base.ParseBytes(br, size);

            /* - TODO parse the bytes in the buffers
             *        That block 6 point to.
             */

        }
    }
}
