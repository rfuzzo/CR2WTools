using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class CStorySceneActionStartWork : CStorySceneAction
{
#region RED Properties

[REDProp("maxTime")]
public float MaxTime { get; set;}

[REDProp("jobTree")]
public Handle<CJobTree> JobTree { get; set;}

[REDProp("category")]
public CName Category { get; set;}

#endregion
}
}