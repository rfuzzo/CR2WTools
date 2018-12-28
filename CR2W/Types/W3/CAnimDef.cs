using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CAnimDef : CObject
{
#region RED Properties

[REDProp("animName")]
public CName AnimName { get; set;}

[REDProp("parent")]
public Ptr<CAnimDef> Parent { get; set;}

[REDProp("shifts")]
public Array<SAnimShift> Shifts { get; set;}

[REDProp("totalTransform")]
public Matrix TotalTransform { get; set;}

[REDProp("duration")]
public float Duration { get; set;}

#endregion
}
}