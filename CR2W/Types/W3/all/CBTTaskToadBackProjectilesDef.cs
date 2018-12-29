using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskToadBackProjectilesDef : CBTTaskProjectileAttackWithPrepareDef
{
#region RED Properties

[REDProp("minDistFromTarget")]
public float MinDistFromTarget { get; set;}

[REDProp("maxDistFromTarget")]
public float MaxDistFromTarget { get; set;}

[REDProp("range")]
public float Range { get; set;}

[REDProp("animEvent")]
public Array<CName> AnimEvent { get; set;}

[REDProp("boneNames")]
public Array<CName> BoneNames { get; set;}

#endregion
}
}