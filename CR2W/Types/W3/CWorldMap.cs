using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CWorldMap : CResource
{
#region RED Properties

[REDProp("guid")]
public CGUID Guid { get; set;}

[REDProp("displayTitle")]
public LocalizedString DisplayTitle { get; set;}

[REDProp("imageInfo")]
public SWorldMapImageInfo ImageInfo { get; set;}

[REDProp("staticMapPins")]
public Array<SStaticMapPin> StaticMapPins { get; set;}

#endregion
}
}