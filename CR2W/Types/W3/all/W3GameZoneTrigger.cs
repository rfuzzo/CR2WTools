using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3GameZoneTrigger : CEntity
{
#region RED Properties

[REDProp("playerEntity")]
public Handle<CPlayer> PlayerEntity { get; set;}

[REDProp("zoneName")]
public CName ZoneName { get; set;}

#endregion
}
}