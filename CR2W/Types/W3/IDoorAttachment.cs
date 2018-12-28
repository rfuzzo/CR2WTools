using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class IDoorAttachment : CHardAttachment
{
#region RED Properties

[REDProp("parent")]
public Ptr<CNode> Parent { get; set;}

[REDProp("child")]
public Ptr<CNode> Child { get; set;}

[REDProp("isBroken")]
public bool IsBroken { get; set;}

[REDProp("relativeTransform")]
public EngineTransform RelativeTransform { get; set;}

[REDProp("parentSlotName")]
public CName ParentSlotName { get; set;}

[REDProp("attachmentFlags")]
public EHardAttachmentFlags AttachmentFlags { get; set;}

[REDProp("parentSlot")]
public Ptr<ISlot> ParentSlot { get; set;}

[REDProp("soundsEvents")]
public SDoorSoundsEvents SoundsEvents { get; set;}

#endregion
}
}