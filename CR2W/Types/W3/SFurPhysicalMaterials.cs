using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class SFurPhysicalMaterials 
{
#region RED Properties

[REDProp("simulation")]
public SFurSimulation Simulation { get; set;}

[REDProp("volume")]
public SFurVolume Volume { get; set;}

[REDProp("strandWidth")]
public SFurStrandWidth StrandWidth { get; set;}

[REDProp("stiffness")]
public SFurStiffness Stiffness { get; set;}

[REDProp("clumping")]
public SFurClumping Clumping { get; set;}

[REDProp("waveness")]
public SFurWaveness Waveness { get; set;}

#endregion
}
}