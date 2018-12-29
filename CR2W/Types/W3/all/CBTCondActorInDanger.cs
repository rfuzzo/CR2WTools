using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTCondActorInDanger : IBehTreeTask
{
#region RED Properties

[REDProp("ignoreEntityWithTag")]
public CName IgnoreEntityWithTag { get; set;}

[REDProp("dangerRadius")]
public float DangerRadius { get; set;}

[REDProp("callFromQuest")]
public bool CallFromQuest { get; set;}

[REDProp("checkQuestRequests")]
public bool CheckQuestRequests { get; set;}

#endregion
}
}