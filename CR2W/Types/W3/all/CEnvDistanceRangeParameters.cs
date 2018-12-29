using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CEnvDistanceRangeParameters 
{
#region RED Properties

[REDProp("activated")]
public bool Activated { get; set;}

[REDProp("distance")]
public SSimpleCurve Distance { get; set;}

[REDProp("range")]
public SSimpleCurve Range { get; set;}

#endregion
}
}