using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class SCommonMapPinInstance 
{
#region RED Properties

[REDProp("id")]
public int Id { get; set;}

[REDProp("tag")]
public CName Tag { get; set;}

[REDProp("customNameId")]
public int CustomNameId { get; set;}

[REDProp("extraTag")]
public CName ExtraTag { get; set;}

[REDProp("type")]
public CName Type { get; set;}

[REDProp("visibleType")]
public CName VisibleType { get; set;}

[REDProp("alternateVersion")]
public int AlternateVersion { get; set;}

[REDProp("position")]
public Vector Position { get; set;}

[REDProp("radius")]
public float Radius { get; set;}

[REDProp("visibleRadius")]
public float VisibleRadius { get; set;}

[REDProp("guid")]
public CGUID Guid { get; set;}

[REDProp("entities")]
public Array<Handle<CEntity>> Entities { get; set;}

[REDProp("isDynamic")]
public bool IsDynamic { get; set;}

[REDProp("isKnown")]
public bool IsKnown { get; set;}

[REDProp("isDiscovered")]
public bool IsDiscovered { get; set;}

[REDProp("isDisabled")]
public bool IsDisabled { get; set;}

[REDProp("isHighlightable")]
public bool IsHighlightable { get; set;}

[REDProp("isHighlighted")]
public bool IsHighlighted { get; set;}

[REDProp("canBePointedByArrow")]
public bool CanBePointedByArrow { get; set;}

[REDProp("canBeAddedToMinimap")]
public bool CanBeAddedToMinimap { get; set;}

[REDProp("isAddedToMinimap")]
public bool IsAddedToMinimap { get; set;}

[REDProp("invalidated")]
public bool Invalidated { get; set;}

#endregion
}
}