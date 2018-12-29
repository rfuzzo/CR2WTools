using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class SSSTrackTransform 
{
#region RED Properties

[REDProp("track")]
public CName Track { get; set;}

[REDProp("value")]
public float Value { get; set;}

#endregion
}
}