using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CR4FinishersDLCMounter : IGameplayDLCMounter
{
#region RED Properties

[REDProp("customCameraAnimSet")]
public Handle<CSkeletalAnimationSet> CustomCameraAnimSet { get; set;}

[REDProp("finishers")]
public Array<Ptr<CR4FinisherDLC>> Finishers { get; set;}

#endregion
}
}