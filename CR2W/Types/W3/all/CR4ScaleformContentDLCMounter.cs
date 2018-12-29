using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CR4ScaleformContentDLCMounter : IGameplayDLCMounter
{
#region RED Properties

[REDProp("scaleformDirectoryPath")]
public string ScaleformDirectoryPath { get; set;}

#endregion
}
}