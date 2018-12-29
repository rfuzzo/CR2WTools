using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskXMLBasedDurationDef : IBehTreeTaskDefinition
{
#region RED Properties

[REDProp("xmlStatName")]
public CName XmlStatName { get; set;}

[REDProp("chance")]
public Int32 Chance { get; set;}

[REDProp("endWithFailure")]
public bool EndWithFailure { get; set;}

#endregion
}
}