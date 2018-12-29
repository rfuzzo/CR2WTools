using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class DeltaDamper : CObject
{
#region RED Properties

[REDProp("destValue")]
public float DestValue { get; set;}

[REDProp("currValue")]
public float CurrValue { get; set;}

[REDProp("dampFactor")]
public float DampFactor { get; set;}

#endregion
}
}