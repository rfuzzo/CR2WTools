using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class SCreatureDefinitionWrapper 
{
#region RED Properties

[REDProp("creatureDefinition")]
public CName CreatureDefinition { get; set;}

#endregion
}
}