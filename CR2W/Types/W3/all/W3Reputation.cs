using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3Reputation : CObject
{
#region RED Properties

[REDProp("factionReputations")]
public Array<Handle<W3FactionReputationPoints>> FactionReputations { get; set;}

[REDProp("factionName")]
public EFactionName FactionName { get; set;}

#endregion
}
}