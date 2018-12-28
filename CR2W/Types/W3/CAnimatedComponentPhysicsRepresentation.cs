using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CAnimatedComponentPhysicsRepresentation : CObject
{
#region RED Properties

[REDProp("ragdoll")]
public Handle<CRagdoll> Ragdoll { get; set;}

[REDProp("ragdollCollisionType")]
public CPhysicalCollision RagdollCollisionType { get; set;}

[REDProp("ragdollAlwaysEnabled")]
public bool RagdollAlwaysEnabled { get; set;}

[REDProp("allowRagdollInCutscene")]
public bool AllowRagdollInCutscene { get; set;}

#endregion
}
}