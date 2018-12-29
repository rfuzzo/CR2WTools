using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class SSimplexTreeStruct 
{
#region RED Properties

[REDProp("parent")]
public int Parent { get; set;}

[REDProp("positiveStruct")]
public int PositiveStruct { get; set;}

[REDProp("negativeStruct")]
public int NegativeStruct { get; set;}

[REDProp("positiveID")]
public int PositiveID { get; set;}

[REDProp("negativeID")]
public int NegativeID { get; set;}

[REDProp("normalX")]
public float NormalX { get; set;}

[REDProp("normalY")]
public float NormalY { get; set;}

[REDProp("offset")]
public float Offset { get; set;}

#endregion
}
}