using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CEvaluatorVectorConst : IEvaluatorVector
{
#region RED Properties

[REDProp("freeAxes")]
public EFreeVectorAxes FreeAxes { get; set;}

[REDProp("spill")]
public bool Spill { get; set;}

[REDProp("value")]
public Vector Value { get; set;}

#endregion
}
}