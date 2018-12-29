using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class SStorySceneCameraBlendKey 
{
#region RED Properties

[REDProp("time")]
public float Time { get; set;}

[REDProp("cameraDefinition")]
public StorySceneCameraDefinition CameraDefinition { get; set;}

#endregion
}
}