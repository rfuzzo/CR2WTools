using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskFlyAroundTargetDef : IBehTreeTaskDefinition
{
#region RED Properties

[REDProp("distance")]
public CBehTreeValFloat Distance { get; set;}

[REDProp("frontalHeadingOffset")]
public CBehTreeValInt FrontalHeadingOffset { get; set;}

[REDProp("randomFactor")]
public CBehTreeValInt RandomFactor { get; set;}

[REDProp("height")]
public CBehTreeValFloat Height { get; set;}

[REDProp("randomHeightAmplitude")]
public CBehTreeValFloat RandomHeightAmplitude { get; set;}

#endregion
}
}