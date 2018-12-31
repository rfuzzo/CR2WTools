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
public class SCurveDataEntry 
{
#region RED Properties

[REDProp("me")]
public float Me { get; set;}

[REDProp("ntrolPoint")]
public Vector NtrolPoint { get; set;}

[REDProp("lue")]
public float Lue { get; set;}

[REDProp("rveTypeL")]
public UInt16 RveTypeL { get; set;}

[REDProp("rveTypeR")]
public UInt16 RveTypeR { get; set;}

#endregion
}
}