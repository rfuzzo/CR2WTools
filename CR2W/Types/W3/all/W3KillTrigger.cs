using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3KillTrigger : CEntity
{
#region RED Properties

[REDProp("postponedTillOnGroundMPAC")]
public Array<Handle<CMovingPhysicalAgentComponent>> PostponedTillOnGroundMPAC { get; set;}

[REDProp("postponeTillOnGround")]
public bool PostponeTillOnGround { get; set;}

[REDProp("postponeTillStoppedFalling")]
public bool PostponeTillStoppedFalling { get; set;}

[REDProp("postponeTillinWater")]
public bool PostponeTillinWater { get; set;}

#endregion
}
}