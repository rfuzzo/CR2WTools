using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class SAbilityAttribute 
{
#region RED Properties

[REDProp("name")]
public CName Name { get; set;}

[REDProp("type")]
public EAbilityAttributeType Type { get; set;}

[REDProp("alwaysRandom")]
public bool AlwaysRandom { get; set;}

[REDProp("min")]
public float Min { get; set;}

[REDProp("max")]
public float Max { get; set;}

[REDProp("precision")]
public sbyte Precision { get; set;}

[REDProp("displayPerc")]
public bool DisplayPerc { get; set;}

#endregion
}
}