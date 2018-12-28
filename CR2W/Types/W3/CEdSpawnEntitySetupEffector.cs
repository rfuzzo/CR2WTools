using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CEdSpawnEntitySetupEffector : IEdEntitySetupEffector
{
#region RED Properties

[REDProp("template")]
public Soft<CEntityTemplate> Template { get; set;}

[REDProp("localPosition")]
public Vector LocalPosition { get; set;}

[REDProp("localOrientation")]
public EulerAngles LocalOrientation { get; set;}

[REDProp("detachTemplate")]
public bool DetachTemplate { get; set;}

[REDProp("extraTags")]
public TagList ExtraTags { get; set;}

#endregion
}
}