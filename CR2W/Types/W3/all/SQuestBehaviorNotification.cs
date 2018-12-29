using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class SQuestBehaviorNotification : CObject
{
#region RED Properties

[REDProp("npcTag")]
public CName NpcTag { get; set;}

[REDProp("notification")]
public CName Notification { get; set;}

[REDProp("all")]
public bool All { get; set;}

#endregion
}
}