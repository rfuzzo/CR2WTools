using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class SBehaviorConstraintStirrupData 
{
#region RED Properties

[REDProp("stirrupBoneName")]
public CName StirrupBoneName { get; set;}

#endregion
}
}