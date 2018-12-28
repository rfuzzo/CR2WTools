using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CControlRigSettings : CObject
{
#region RED Properties

[REDProp("fkBonesNames_l1")]
public Array<CName> FkBonesNames_l1 { get; set;}

[REDProp("fkBones_l1")]
public Array<Int32> FkBones_l1 { get; set;}

[REDProp("ikBonesNames")]
public Array<CName> IkBonesNames { get; set;}

[REDProp("ikBones")]
public Array<Int32> IkBones { get; set;}

#endregion
}
}