using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskPreCombatWarningDef : IBehTreeTaskDefinition
{
#region RED Properties

[REDProp("setFlagOnActivate")]
public bool SetFlagOnActivate { get; set;}

[REDProp("setFlagOnDectivate")]
public bool SetFlagOnDectivate { get; set;}

[REDProp("flag")]
public bool Flag { get; set;}

#endregion
}
}