using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3Effect_Mutation10 : CBaseGameplayEffect
{
#region RED Properties

[REDProp("bonusPerPoint")]
public float BonusPerPoint { get; set;}

#endregion
}
}