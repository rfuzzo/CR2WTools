using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class SBehaviorComboAnim 
{
#region RED Properties

[REDProp("animationAttack")]
public CName AnimationAttack { get; set;}

[REDProp("animationParry")]
public CName AnimationParry { get; set;}

[REDProp("id")]
public int Id { get; set;}

#endregion
}
}