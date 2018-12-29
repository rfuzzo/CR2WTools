using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskElementalDaoStoneSmashDef : CBTTaskAttackDef
{
#region RED Properties

[REDProp("stoneEntityTemplate")]
public Handle<CEntityTemplate> StoneEntityTemplate { get; set;}

[REDProp("dodgeable")]
public bool Dodgeable { get; set;}

#endregion
}
}