using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class SSSBoneTransform 
{
#region RED Properties

[REDProp("bone")]
public CName Bone { get; set;}

[REDProp("transform")]
public EngineTransform Transform { get; set;}

#endregion
}
}