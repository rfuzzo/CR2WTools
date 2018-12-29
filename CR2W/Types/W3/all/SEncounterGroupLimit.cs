using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class SEncounterGroupLimit 
{
#region RED Properties

[REDProp("groupName")]
public CName GroupName { get; set;}

[REDProp("limit")]
public uint Limit { get; set;}

#endregion
}
}