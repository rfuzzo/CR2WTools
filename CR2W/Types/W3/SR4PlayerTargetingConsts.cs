using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class SR4PlayerTargetingConsts 
{
#region RED Properties

[REDProp("softLockDistance")]
public float SoftLockDistance { get; set;}

[REDProp("softLockFrameSize")]
public float SoftLockFrameSize { get; set;}

#endregion
}
}