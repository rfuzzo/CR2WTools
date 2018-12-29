using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTCondActorInDangerDef : IBehTreeConditionalTaskDefinition
{
#region RED Properties

[REDProp("dangerRadius")]
public float DangerRadius { get; set;}

[REDProp("checkQuestRequests")]
public bool CheckQuestRequests { get; set;}

[REDProp("ignoreEntityWithTag")]
public CName IgnoreEntityWithTag { get; set;}

#endregion
}
}