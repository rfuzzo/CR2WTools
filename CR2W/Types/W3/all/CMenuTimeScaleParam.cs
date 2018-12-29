using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CMenuTimeScaleParam : IMenuTimeParam
{
#region RED Properties

[REDProp("timeScale")]
public float TimeScale { get; set;}

[REDProp("multiplicative")]
public bool Multiplicative { get; set;}

#endregion
}
}