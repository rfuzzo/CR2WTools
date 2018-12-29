using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CDoorAttachment_AngleAnimation : IDoorAttachment
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

[REDProp("openTime")]
public float OpenTime { get; set;}

[REDProp("originalAngle")]
public float OriginalAngle { get; set;}

#endregion
}
}