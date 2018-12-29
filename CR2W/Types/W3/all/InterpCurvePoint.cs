using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class InterpCurvePoint : CObject
{
#region RED Properties

[REDProp("inVal")]
public float InVal { get; set;}

[REDProp("interpMode")]
public EInterpCurveMode InterpMode { get; set;}

#endregion
}
}