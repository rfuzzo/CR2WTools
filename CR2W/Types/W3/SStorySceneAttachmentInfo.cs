using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class SStorySceneAttachmentInfo 
{
#region RED Properties

[REDProp("attachTo")]
public CName AttachTo { get; set;}

[REDProp("parentSlotName")]
public CName ParentSlotName { get; set;}

[REDProp("freePositionAxisX")]
public bool FreePositionAxisX { get; set;}

[REDProp("freePositionAxisY")]
public bool FreePositionAxisY { get; set;}

[REDProp("freePositionAxisZ")]
public bool FreePositionAxisZ { get; set;}

[REDProp("freeRotation")]
public bool FreeRotation { get; set;}

#endregion
}
}