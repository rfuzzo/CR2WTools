using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CR4ResourceDefinitionsDLCMounter : IGameplayDLCMounter
{
#region RED Properties

[REDProp("resourceDefinitionXmlFilePath")]
public string ResourceDefinitionXmlFilePath { get; set;}

#endregion
}
}