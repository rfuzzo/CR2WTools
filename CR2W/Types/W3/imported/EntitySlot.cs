using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using CR2W.IO;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class EntitySlot 
{
#region RED Properties

[REDProp("wasIncluded")]
public bool WasIncluded { get; set;}

[REDProp("name")]
public CName Name { get; set;}

[REDProp("componentName")]
public CName ComponentName { get; set;}

[REDProp("boneName")]
public CName BoneName { get; set;}

[REDProp("transform")]
public EngineTransform Transform { get; set;}

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