using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class SBehaviorComboLevel 
{
#region RED Properties

[REDProp("dirFront")]
public SBehaviorComboDirection DirFront { get; set;}

[REDProp("dirBack")]
public SBehaviorComboDirection DirBack { get; set;}

[REDProp("dirLeft")]
public SBehaviorComboDirection DirLeft { get; set;}

[REDProp("dirRight")]
public SBehaviorComboDirection DirRight { get; set;}

[REDProp("abilityRequired")]
public CName AbilityRequired { get; set;}

#endregion
}
}