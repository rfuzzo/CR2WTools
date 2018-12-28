using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CSkeletonBoneSlot : ISlot
{
#region RED Properties

[REDProp("boneIndex")]
public uint BoneIndex { get; set;}

#endregion
}
}