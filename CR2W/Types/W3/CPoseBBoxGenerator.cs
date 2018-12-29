using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class CPoseBBoxGenerator : CObject
{
#region RED Properties

[REDProp("boneNames")]
public Array<string> BoneNames { get; set;}

[REDProp("boneIndex")]
public Array<Int32> BoneIndex { get; set;}

#endregion
}
}