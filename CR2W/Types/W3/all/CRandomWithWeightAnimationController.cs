using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CRandomWithWeightAnimationController : CSequentialAnimationController
{
#region RED Properties

[REDProp("collectEvents")]
public bool CollectEvents { get; set;}

[REDProp("animations")]
public Array<CName> Animations { get; set;}

[REDProp("speeds")]
public Array<float> Speeds { get; set;}

[REDProp("startingOffsetRange")]
public float StartingOffsetRange { get; set;}

[REDProp("startingOffsetBias")]
public float StartingOffsetBias { get; set;}

[REDProp("weights")]
public Array<float> Weights { get; set;}

#endregion
}
}