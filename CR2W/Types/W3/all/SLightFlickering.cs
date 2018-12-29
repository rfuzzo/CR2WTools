using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class SLightFlickering 
{
#region RED Properties

[REDProp("positionOffset")]
public float PositionOffset { get; set;}

[REDProp("flickerStrength")]
public float FlickerStrength { get; set;}

[REDProp("flickerPeriod")]
public float FlickerPeriod { get; set;}

#endregion
}
}