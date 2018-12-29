using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class CR4SceneAnimationsDLCMounter : IGameplayDLCMounter
{
#region RED Properties

[REDProp("sceneAnimationsBodyFilePath")]
public string SceneAnimationsBodyFilePath { get; set;}

[REDProp("sceneAnimationsMimicsFilePath")]
public string SceneAnimationsMimicsFilePath { get; set;}

[REDProp("sceneAnimationsMimicsEmoStatesFilePath")]
public string SceneAnimationsMimicsEmoStatesFilePath { get; set;}

#endregion
}
}