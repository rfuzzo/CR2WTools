using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CMaterialOverrideAttachmentSelectByChunk : CMaterialOverrideAttachment
{
#region RED Properties

[REDProp("parent")]
public Ptr<CNode> Parent { get; set;}

[REDProp("child")]
public Ptr<CNode> Child { get; set;}

[REDProp("isBroken")]
public bool IsBroken { get; set;}

[REDProp("chunkIndices")]
public Array<uint> ChunkIndices { get; set;}

#endregion
}
}