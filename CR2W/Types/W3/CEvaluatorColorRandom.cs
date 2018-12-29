using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class CEvaluatorColorRandom : IEvaluatorColor
{
#region RED Properties

[REDProp("value")]
public Color Value { get; set;}

#endregion
}
}