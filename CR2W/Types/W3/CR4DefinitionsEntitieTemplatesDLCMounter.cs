using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CR4DefinitionsEntitieTemplatesDLCMounter : IGameplayDLCMounter
{
#region RED Properties

[REDProp("entitieTemplatesDirectoryPath")]
public string EntitieTemplatesDirectoryPath { get; set;}

#endregion
}
}