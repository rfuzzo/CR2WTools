using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3FastTravelEntity : CR4FastTravelEntity
{
#region RED Properties

[REDProp("onAreaExit")]
public bool OnAreaExit { get; set;}

[REDProp("warningTextStringKeyOverride")]
public string WarningTextStringKeyOverride { get; set;}

[REDProp("onelinerSceneOverride")]
public Handle<CStoryScene> OnelinerSceneOverride { get; set;}

[REDProp("overrideSceneInput")]
public CName OverrideSceneInput { get; set;}

#endregion
}
}