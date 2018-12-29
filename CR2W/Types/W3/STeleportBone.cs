using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class STeleportBone 
{
#region RED Properties

[REDProp("boneName")]
public CName BoneName { get; set;}

[REDProp("teleportDetectionAxisLS")]
public EAxis TeleportDetectionAxisLS { get; set;}

#endregion
}
}