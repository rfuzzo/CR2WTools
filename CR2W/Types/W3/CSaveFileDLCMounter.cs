using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CSaveFileDLCMounter : IGameplayDLCMounter
{
#region RED Properties

[REDProp("starterSaveFilePath")]
public string StarterSaveFilePath { get; set;}

#endregion
}
}