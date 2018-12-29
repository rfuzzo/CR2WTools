using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3CiriPhantom : CGameplayEntity
{
#region RED Properties

[REDProp("owner")]
public Handle<CActor> Owner { get; set;}

[REDProp("target")]
public Handle<CActor> Target { get; set;}

[REDProp("rotationDamper")]
public Handle<EulerAnglesSpringDamper> RotationDamper { get; set;}

#endregion
}
}