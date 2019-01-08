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
public class IEvaluatorVector : IEvaluator
{
#region RED Properties

[REDProp("freeAxes")]
public EFreeVectorAxes FreeAxes { get; set;}

[REDProp("spill")]
public bool Spill { get; set;}

#endregion
}
}