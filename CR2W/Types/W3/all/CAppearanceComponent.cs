using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CAppearanceComponent : CComponent
{
#region RED Properties

[REDProp("tags")]
public TagList Tags { get; set;}

[REDProp("transform")]
public EngineTransform Transform { get; set;}

[REDProp("transformParent")]
public Ptr<CHardAttachment> TransformParent { get; set;}

[REDProp("guid")]
public CGUID Guid { get; set;}

[REDProp("name")]
public string Name { get; set;}

[REDProp("isStreamed")]
public bool IsStreamed { get; set;}

[REDProp("forcedAppearance")]
public CName ForcedAppearance { get; set;}

[REDProp("attachmentReplacements")]
public SAttachmentReplacements AttachmentReplacements { get; set;}

[REDProp("appearanceAttachments")]
public Array<SAppearanceAttachments> AppearanceAttachments { get; set;}

#endregion
}
}