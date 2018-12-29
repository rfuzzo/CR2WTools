using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CAINpcSorceressTacticTreeParams : CAINpcTacticTreeParams
{
#region RED Properties

[REDProp("minStrafeDist")]
public float MinStrafeDist { get; set;}

[REDProp("maxStrafeDist")]
public float MaxStrafeDist { get; set;}

[REDProp("minFarStrafeDist")]
public float MinFarStrafeDist { get; set;}

[REDProp("maxFarStrafeDist")]
public float MaxFarStrafeDist { get; set;}

#endregion
}
}