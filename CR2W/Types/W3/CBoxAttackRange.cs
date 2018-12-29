using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class CBoxAttackRange : CAIAttackRange
{
#region RED Properties

[REDProp("name")]
public CName Name { get; set;}

[REDProp("rangeMax")]
public float RangeMax { get; set;}

[REDProp("height")]
public float Height { get; set;}

[REDProp("angleOffset")]
public float AngleOffset { get; set;}

[REDProp("position")]
public Vector Position { get; set;}

[REDProp("checkLineOfSight")]
public bool CheckLineOfSight { get; set;}

[REDProp("lineOfSightHeight")]
public float LineOfSightHeight { get; set;}

[REDProp("useHeadOrientation")]
public bool UseHeadOrientation { get; set;}

[REDProp("rangeWidth")]
public float RangeWidth { get; set;}

#endregion
}
}