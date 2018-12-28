using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CMoveSCWaitingForNotification : IMoveSteeringCondition
{
#region RED Properties

[REDProp("notificationName")]
public CName NotificationName { get; set;}

#endregion
}
}