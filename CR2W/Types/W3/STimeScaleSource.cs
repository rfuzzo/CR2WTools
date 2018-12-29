using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class STimeScaleSource 
{
#region RED Properties

[REDProp("timeScale")]
public float TimeScale { get; set;}

[REDProp("name")]
public CName Name { get; set;}

[REDProp("affectCamera")]
public bool AffectCamera { get; set;}

[REDProp("dontSave")]
public bool DontSave { get; set;}

[REDProp("priorityIndex")]
public uint PriorityIndex { get; set;}

#endregion
}
}