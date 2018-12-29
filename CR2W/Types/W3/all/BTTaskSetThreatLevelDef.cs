using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class BTTaskSetThreatLevelDef : IBehTreeTaskDefinition
{
#region RED Properties

[REDProp("threatLevel")]
public Int32 ThreatLevel { get; set;}

[REDProp("addToCurrent")]
public bool AddToCurrent { get; set;}

#endregion
}
}