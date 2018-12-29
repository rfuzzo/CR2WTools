using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskLockViewToDettlaffDef : IBehTreeTaskDefinition
{
#region RED Properties

[REDProp("lock")]
public bool Lock { get; set;}

[REDProp("actor")]
public Handle<CActor> Actor { get; set;}

#endregion
}
}