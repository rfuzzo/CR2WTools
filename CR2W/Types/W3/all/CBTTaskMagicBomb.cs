using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskMagicBomb : CBTTaskAttack
{
#region RED Properties

[REDProp("resourceName")]
public CName ResourceName { get; set;}

[REDProp("targetPos")]
public Vector TargetPos { get; set;}

[REDProp("targetRot")]
public EulerAngles TargetRot { get; set;}

[REDProp("entity")]
public Handle<CEntity> Entity { get; set;}

[REDProp("entityTemplate")]
public Handle<CEntityTemplate> EntityTemplate { get; set;}

#endregion
}
}