using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3ReplacerCiri : W3Replacer
{
#region RED Properties

[REDProp("isInitialized")]
public bool IsInitialized { get; set;}

[REDProp("ciriPhantoms")]
public Array<Handle<W3CiriPhantom>> CiriPhantoms { get; set;}

[REDProp("bloodExplode")]
public Handle<CEntityTemplate> BloodExplode { get; set;}

[REDProp("rageEffectEnabled")]
public bool RageEffectEnabled { get; set;}

[REDProp("tempIsCollisionDisabled")]
public bool TempIsCollisionDisabled { get; set;}

[REDProp("collidedEnemies")]
public Array<Handle<CActor>> CollidedEnemies { get; set;}

[REDProp("slidingToNewPosition")]
public bool SlidingToNewPosition { get; set;}

[REDProp("cameraDesiredHeading")]
public Vector CameraDesiredHeading { get; set;}

#endregion
}
}