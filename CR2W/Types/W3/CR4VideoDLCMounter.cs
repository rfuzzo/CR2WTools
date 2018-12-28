using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CR4VideoDLCMounter : IGameplayDLCMounter
{
#region RED Properties

[REDProp("videoDirectoryPath")]
public string VideoDirectoryPath { get; set;}

#endregion
}
}