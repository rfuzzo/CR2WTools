using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CSkeletalAnimationTrajectoryTrackParam : ISkeletalAnimationSetEntryParam
{
#region RED Properties

[REDProp("editorOnly")]
public bool EditorOnly { get; set;}

[REDProp("names")]
public Array<CName> Names { get; set;}

[REDProp("datas")]
public Array<Array<Vector>> Datas { get; set;}

#endregion
}
}