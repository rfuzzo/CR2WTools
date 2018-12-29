using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class SBehaviorConstraintPullReinToHandData 
{
#region RED Properties

[REDProp("reinBoneName")]
public CName ReinBoneName { get; set;}

[REDProp("reinContactPoint")]
public Vector ReinContactPoint { get; set;}

[REDProp("handBoneName")]
public CName HandBoneName { get; set;}

[REDProp("handContactPoint")]
public Vector HandContactPoint { get; set;}

#endregion
}
}