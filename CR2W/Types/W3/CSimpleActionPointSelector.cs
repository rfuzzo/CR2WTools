using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CSimpleActionPointSelector : CActionPointSelector
{
#region RED Properties

[REDProp("categories")]
public Array<CName> Categories { get; set;}

[REDProp("apTags")]
public TagList ApTags { get; set;}

[REDProp("areaTags")]
public TagList AreaTags { get; set;}

[REDProp("apAreaTag")]
public CName ApAreaTag { get; set;}

[REDProp("keepActionPointOnceSelected")]
public bool KeepActionPointOnceSelected { get; set;}

[REDProp("useNearestMatchingAP")]
public bool UseNearestMatchingAP { get; set;}

#endregion
}
}