using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTAddTag : IBehTreeTask
{
#region RED Properties

[REDProp("tag")]
public CName Tag { get; set;}

[REDProp("toOwner")]
public bool ToOwner { get; set;}

[REDProp("toTarget")]
public bool ToTarget { get; set;}

[REDProp("useCombatTarget")]
public bool UseCombatTarget { get; set;}

[REDProp("onActivate")]
public bool OnActivate { get; set;}

[REDProp("onDeactivate")]
public bool OnDeactivate { get; set;}

#endregion
}
}