using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBrushFace : CObject
{
#region RED Properties

[REDProp("material")]
public Handle<IMaterial> Material { get; set;}

[REDProp("mapping")]
public EBrushFaceMapping Mapping { get; set;}

[REDProp("scaleU")]
public float ScaleU { get; set;}

[REDProp("scaleV")]
public float ScaleV { get; set;}

[REDProp("offsetU")]
public float OffsetU { get; set;}

[REDProp("offsetV")]
public float OffsetV { get; set;}

[REDProp("rotation")]
public float Rotation { get; set;}

[REDProp("renderFaceID")]
public int RenderFaceID { get; set;}

#endregion
}
}