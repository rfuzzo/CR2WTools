using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CR4AttitudesDLCMounter : IGameplayDLCMounter
{
#region RED Properties

[REDProp("attitudeGroupsTableFilePath")]
public string AttitudeGroupsTableFilePath { get; set;}

[REDProp("attitudesXMLFilePath")]
public string AttitudesXMLFilePath { get; set;}

#endregion
}
}