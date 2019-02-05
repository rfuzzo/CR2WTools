using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RED.Core
{
    public class CTerrainTile : CResource
    {
        [RED] protected uint tileFileVersion;
        [RED] protected ETerrainTileCollision collisionType;
        [RED] protected ushort maxHeightValue;
        [RED] protected ushort minHeightValue;
    }
}