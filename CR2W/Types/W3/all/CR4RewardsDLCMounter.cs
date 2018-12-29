using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CR4RewardsDLCMounter : IGameplayDLCMounter
{
#region RED Properties

[REDProp("rewordsXmlFilePath")]
public string RewordsXmlFilePath { get; set;}

#endregion
}
}