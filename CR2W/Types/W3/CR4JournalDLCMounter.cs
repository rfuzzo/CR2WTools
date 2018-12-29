using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class CR4JournalDLCMounter : IGameplayDLCMounter
{
#region RED Properties

[REDProp("journalDirectoryPath")]
public string JournalDirectoryPath { get; set;}

#endregion
}
}