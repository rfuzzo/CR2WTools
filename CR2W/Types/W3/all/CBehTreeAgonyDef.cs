using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBehTreeAgonyDef : IBehTreeTaskDefinition
{
#region RED Properties

[REDProp("disableAgony")]
public CBehTreeValBool DisableAgony { get; set;}

[REDProp("agonyTime")]
public Int32 AgonyTime { get; set;}

[REDProp("chance")]
public Int32 Chance { get; set;}

#endregion
}
}