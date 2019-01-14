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
public class SSimplexTreeStruct 
{
#region RED Properties

[REDProp("parent")]
public Int32 Parent { get; set;}

[REDProp("positiveStruct")]
public Int32 PositiveStruct { get; set;}

[REDProp("negativeStruct")]
public Int32 NegativeStruct { get; set;}

[REDProp("positiveID")]
public Int32 PositiveID { get; set;}

[REDProp("negativeID")]
public Int32 NegativeID { get; set;}

[REDProp("normalX")]
public float NormalX { get; set;}

[REDProp("normalY")]
public float NormalY { get; set;}

[REDProp("offset")]
public float Offset { get; set;}

#endregion
}
}