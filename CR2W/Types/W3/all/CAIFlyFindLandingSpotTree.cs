using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CAIFlyFindLandingSpotTree : IFlightActionTree
{
#region RED Properties

[REDProp("landingAnimations")]
public Array<Handle<CAIFlyLandTree>> LandingAnimations { get; set;}

#endregion
}
}