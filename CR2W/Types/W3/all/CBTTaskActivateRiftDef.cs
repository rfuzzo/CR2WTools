using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskActivateRiftDef : CBTTaskAttackDef
{
#region RED Properties

[REDProp("resourceNameRift")]
public CName ResourceNameRift { get; set;}

[REDProp("resourceNameGround")]
public CName ResourceNameGround { get; set;}

#endregion
}
}