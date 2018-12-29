using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskActivateRift : CBTTaskAttack
{
#region RED Properties

[REDProp("resourceNameRift")]
public CName ResourceNameRift { get; set;}

[REDProp("resourceNameGround")]
public CName ResourceNameGround { get; set;}

[REDProp("entityRiftTemplate")]
public Handle<CEntityTemplate> EntityRiftTemplate { get; set;}

[REDProp("entityGroundTemplate")]
public Handle<CEntityTemplate> EntityGroundTemplate { get; set;}

[REDProp("targetPos")]
public Vector TargetPos { get; set;}

[REDProp("targetRot")]
public EulerAngles TargetRot { get; set;}

[REDProp("heightOffset")]
public float HeightOffset { get; set;}

[REDProp("entityRift")]
public Handle<CEntity> EntityRift { get; set;}

[REDProp("entityGround")]
public Handle<CEntity> EntityGround { get; set;}

[REDProp("casterPos")]
public Vector CasterPos { get; set;}

[REDProp("riftPos")]
public Vector RiftPos { get; set;}

[REDProp("rift")]
public Handle<CRiftEntity> Rift { get; set;}

[REDProp("ground")]
public Handle<CRiftEntity> Ground { get; set;}

[REDProp("npc")]
public Handle<CNewNPC> Npc { get; set;}

[REDProp("couldntLoadResource")]
public bool CouldntLoadResource { get; set;}

#endregion
}
}