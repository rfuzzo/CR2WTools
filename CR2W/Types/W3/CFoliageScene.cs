using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class CFoliageScene : CObject
{
#region RED Properties

[REDProp("worldDimensions")]
public Vector2 WorldDimensions { get; set;}

[REDProp("cellDimensions")]
public Vector2 CellDimensions { get; set;}

[REDProp("visibilityDepth")]
public int VisibilityDepth { get; set;}

[REDProp("editorVisibilityDepth")]
public int EditorVisibilityDepth { get; set;}

[REDProp("grassMask")]
public Handle<CGenericGrassMask> GrassMask { get; set;}

[REDProp("grassOccurrenceMap")]
public Ptr<CGrassOccurrenceMap> GrassOccurrenceMap { get; set;}

[REDProp("lodSetting")]
public SFoliageLODSetting LodSetting { get; set;}

#endregion
}
}