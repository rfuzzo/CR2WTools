using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3Potion_Fact_Params : W3PotionParams
{
#region RED Properties

[REDProp("factName")]
public CName FactName { get; set;}

#endregion
}
}