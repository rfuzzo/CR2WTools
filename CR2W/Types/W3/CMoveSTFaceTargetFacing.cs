using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class CMoveSTFaceTargetFacing : IMoveTargetSteeringTask
{
#region RED Properties

[REDProp("namedTarget")]
public CName NamedTarget { get; set;}

#endregion
}
}