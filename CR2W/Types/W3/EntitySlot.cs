using System;
using System.IO;
using System.Drawing;
using CR2W.IO;
using CR2W.Attributes;

namespace CR2W.Types.W3
{
    public class EntitySlot : CResource
    {
        [W3Type("wasIncluded")]
        public bool WasIncluded { get; set; }

        [W3Type("name")]
        public CName Name { get; set; }

        [W3Type("componentName")]
        public CName ComponentName { get; set; }

        [W3Type("boneName")]
        public CName BoneName { get; set; }

        [W3Type("transform")]
        public EngineTransform Transform { get; set; }

        [W3Type("freePositionAxisX")]
        public bool FreePositionAxisX { get; set; }

        [W3Type("freePositionAxisY")]
        public bool FreePositionAxisY { get; set; }

        [W3Type("freePositionAxisZ")]
        public bool FreePositionAxisZ { get; set; }

        [W3Type("freeRotation")]
        public bool FreeRotation { get; set; }

    }
}
 