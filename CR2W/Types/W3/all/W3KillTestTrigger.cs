using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3KillTestTrigger : CGameplayEntity
{
#region RED Properties

[REDProp("entered")]
public bool Entered { get; set;}

[REDProp("actors")]
public Array<Handle<CActor>> Actors { get; set;}

[REDProp("entityTemplate")]
public Handle<CEntityTemplate> EntityTemplate { get; set;}

#endregion
}
}