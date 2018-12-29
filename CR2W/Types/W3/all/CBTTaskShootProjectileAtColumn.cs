using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskShootProjectileAtColumn : IBehTreeTask
{
#region RED Properties

[REDProp("l_npc")]
public Handle<CNewNPC> L_npc { get; set;}

[REDProp("l_projRot")]
public EulerAngles L_projRot { get; set;}

[REDProp("l_projPos")]
public Vector L_projPos { get; set;}

[REDProp("l_projectile")]
public Handle<W3AdvancedProjectile> L_projectile { get; set;}

[REDProp("projEntity")]
public Handle<CEntityTemplate> ProjEntity { get; set;}

[REDProp("l_columnArray")]
public Array<Handle<CEntity>> L_columnArray { get; set;}

#endregion
}
}