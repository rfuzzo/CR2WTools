using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class SAnimationSequenceDefinition 
{
#region RED Properties

[REDProp("entity")]
public Handle<CEntity> Entity { get; set;}

[REDProp("manualSlotName")]
public CName ManualSlotName { get; set;}

[REDProp("parts")]
public Array<SAnimationSequencePartDefinition> Parts { get; set;}

[REDProp("freezeAtEnd")]
public bool FreezeAtEnd { get; set;}

[REDProp("startForceEvent")]
public CName StartForceEvent { get; set;}

[REDProp("raiseEventOnEnd")]
public CName RaiseEventOnEnd { get; set;}

[REDProp("raiseForceEventOnEnd")]
public CName RaiseForceEventOnEnd { get; set;}

#endregion
}
}