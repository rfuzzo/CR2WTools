using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CR4DefinitionsNGPlusDLCMounter : CR4DefinitionsDLCMounter
{
#region RED Properties

[REDProp("definitionXmlFilePath")]
public string DefinitionXmlFilePath { get; set;}

#endregion
}
}