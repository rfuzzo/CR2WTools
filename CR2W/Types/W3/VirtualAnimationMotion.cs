using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class VirtualAnimationMotion 
{
#region RED Properties

[REDProp("startTime")]
public float StartTime { get; set;}

[REDProp("endTime")]
public float EndTime { get; set;}

[REDProp("blendIn")]
public float BlendIn { get; set;}

[REDProp("blendOut")]
public float BlendOut { get; set;}

#endregion
}
}