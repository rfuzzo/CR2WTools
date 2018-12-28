using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CRainActionPointSelector : CWanderActionPointSelector
{
#region RED Properties

[REDProp("categories")]
public Array<SEncounterActionPointSelectorPair> Categories { get; set;}

[REDProp("delay")]
public float Delay { get; set;}

[REDProp("radius")]
public float Radius { get; set;}

[REDProp("apTags")]
public TagList ApTags { get; set;}

[REDProp("areaTags")]
public TagList AreaTags { get; set;}

[REDProp("apAreaTag")]
public CName ApAreaTag { get; set;}

[REDProp("chooseClosestAP")]
public bool ChooseClosestAP { get; set;}

#endregion
}
}