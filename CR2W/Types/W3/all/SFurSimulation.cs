using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class SFurSimulation 
{
#region RED Properties

[REDProp("simulate")]
public bool Simulate { get; set;}

[REDProp("massScale")]
public float MassScale { get; set;}

[REDProp("damping")]
public float Damping { get; set;}

[REDProp("friction")]
public float Friction { get; set;}

[REDProp("backStopRadius")]
public float BackStopRadius { get; set;}

[REDProp("inertiaScale")]
public float InertiaScale { get; set;}

[REDProp("inertiaLimit")]
public float InertiaLimit { get; set;}

[REDProp("useCollision")]
public bool UseCollision { get; set;}

[REDProp("windScaler")]
public float WindScaler { get; set;}

[REDProp("windNoise")]
public float WindNoise { get; set;}

[REDProp("gravityDir")]
public Vector GravityDir { get; set;}

#endregion
}
}