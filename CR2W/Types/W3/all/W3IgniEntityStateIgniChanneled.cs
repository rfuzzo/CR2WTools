using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3IgniEntityStateIgniChanneled : W3SignEntityStateChanneling
{
#region RED Properties

[REDProp("reusableProjectiles")]
public Array<Handle<W3IgniProjectile>> ReusableProjectiles { get; set;}

#endregion
}
}