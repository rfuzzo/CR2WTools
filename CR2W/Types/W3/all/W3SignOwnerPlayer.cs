using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3SignOwnerPlayer : W3SignOwner
{
#region RED Properties

[REDProp("player")]
public Handle<W3PlayerWitcher> Player { get; set;}

#endregion
}
}