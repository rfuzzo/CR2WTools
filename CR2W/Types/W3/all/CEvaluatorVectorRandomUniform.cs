using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CEvaluatorVectorRandomUniform : IEvaluatorVector
{
#region RED Properties

[REDProp("freeAxes")]
public EFreeVectorAxes FreeAxes { get; set;}

[REDProp("spill")]
public bool Spill { get; set;}

[REDProp("min")]
public Vector Min { get; set;}

[REDProp("max")]
public Vector Max { get; set;}

#endregion
}
}