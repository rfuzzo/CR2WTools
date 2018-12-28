using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CR4DefinitionsDLCMounter : IGameplayDLCMounter
{
#region RED Properties

[REDProp("definitionXmlFilePath")]
public string DefinitionXmlFilePath { get; set;}

#endregion
}
}