using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBehTreeTaskProcessCrossbowBolts : IBehTreeTaskProcessProjectile
{
#region RED Properties

[REDProp("bolt")]
public Handle<W3AdvancedProjectile> Bolt { get; set;}

#endregion
}
}