using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskRiderSetCanBeFollowed : IBehTreeTask
{
#region RED Properties

[REDProp("setCanBeFollowed")]
public bool SetCanBeFollowed { get; set;}

[REDProp("horse")]
public Handle<CNewNPC> Horse { get; set;}

#endregion
}
}