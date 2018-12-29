using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CFXSimpleSpawner : IFXSpawner
{
#region RED Properties

[REDProp("slotNames")]
public Array<CName> SlotNames { get; set;}

[REDProp("boneNames")]
public Array<CName> BoneNames { get; set;}

[REDProp("relativePos")]
public Vector RelativePos { get; set;}

[REDProp("relativeRot")]
public EulerAngles RelativeRot { get; set;}

#endregion
}
}