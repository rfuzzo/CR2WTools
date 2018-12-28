using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CStorySceneDialogsetInstance : CObject
{
#region RED Properties

[REDProp("name")]
public CName Name { get; set;}

[REDProp("slots")]
public Array<Ptr<CStorySceneDialogsetSlot>> Slots { get; set;}

[REDProp("placementTag")]
public TagList PlacementTag { get; set;}

[REDProp("snapToTerrain")]
public bool SnapToTerrain { get; set;}

[REDProp("findSafePlacement")]
public bool FindSafePlacement { get; set;}

[REDProp("safePlacementRadius")]
public float SafePlacementRadius { get; set;}

[REDProp("areCamerasUsedForBoundsCalculation")]
public bool AreCamerasUsedForBoundsCalculation { get; set;}

[REDProp("path")]
public string Path { get; set;}

#endregion
}
}