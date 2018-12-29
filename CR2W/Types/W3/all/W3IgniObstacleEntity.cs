using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3IgniObstacleEntity : CInteractiveEntity
{
#region RED Properties

[REDProp("staticIgniObstacle")]
public Handle<CComponent> StaticIgniObstacle { get; set;}

[REDProp("iceWallStage1")]
public Handle<CDrawableComponent> IceWallStage1 { get; set;}

[REDProp("iceWallStage2")]
public Handle<CDrawableComponent> IceWallStage2 { get; set;}

[REDProp("iceWallStage2Melted")]
public Handle<CDrawableComponent> IceWallStage2Melted { get; set;}

[REDProp("iceWallStage3")]
public Handle<CDrawableComponent> IceWallStage3 { get; set;}

[REDProp("iceWallStage3Melted")]
public Handle<CDrawableComponent> IceWallStage3Melted { get; set;}

#endregion
}
}