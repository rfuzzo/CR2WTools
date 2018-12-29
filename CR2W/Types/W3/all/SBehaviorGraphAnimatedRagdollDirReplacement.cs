using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class SBehaviorGraphAnimatedRagdollDirReplacement 
{
#region RED Properties

[REDProp("probability")]
public float Probability { get; set;}

[REDProp("index")]
public uint Index { get; set;}

#endregion
}
}