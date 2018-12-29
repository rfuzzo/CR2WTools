using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class SInputAction 
{
#region RED Properties

[REDProp("aName")]
public CName AName { get; set;}

[REDProp("value")]
public float Value { get; set;}

[REDProp("lastFrameValue")]
public float LastFrameValue { get; set;}

#endregion
}
}