using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CEquipmentDefinition : CEntityTemplateParam
{
#region RED Properties

[REDProp("wasIncluded")]
public bool WasIncluded { get; set;}

[REDProp("entries")]
public Array<Ptr<CEquipmentDefinitionEntry>> Entries { get; set;}

#endregion
}
}