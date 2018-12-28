using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CStorySceneActionEquipItem : CStorySceneAction
{
#region RED Properties

[REDProp("maxTime")]
public float MaxTime { get; set;}

[REDProp("leftHandItem")]
public CName LeftHandItem { get; set;}

[REDProp("rightHandItem")]
public CName RightHandItem { get; set;}

#endregion
}
}