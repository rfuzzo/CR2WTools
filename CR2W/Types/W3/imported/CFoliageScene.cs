using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using CR2W.IO;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CFoliageScene : CObject
{
#region RED Properties

[REDProp("worldDimensions")]
public Vector2 WorldDimensions { get; set;}

[REDProp("cellDimensions")]
public Vector2 CellDimensions { get; set;}

[REDProp("visibilityDepth")]
public Int32 VisibilityDepth { get; set;}

[REDProp("editorVisibilityDepth")]
public Int32 EditorVisibilityDepth { get; set;}

[REDProp("grassMask")]
public Handle<CGenericGrassMask> GrassMask { get; set;}

[REDProp("grassOccurrenceMap")]
public Ptr<CGrassOccurrenceMap> GrassOccurrenceMap { get; set;}

[REDProp("lodSetting")]
public SFoliageLODSetting LodSetting { get; set;}

#endregion
}
}