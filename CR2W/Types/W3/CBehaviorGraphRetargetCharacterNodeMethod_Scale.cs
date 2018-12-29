using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class CBehaviorGraphRetargetCharacterNodeMethod_Scale : IBehaviorGraphRetargetCharacterNodeMethod
{
#region RED Properties

[REDProp("scaleFactor")]
public float ScaleFactor { get; set;}

#endregion
}
}