using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3ScentComponent : CR4Component
{
#region RED Properties

[REDProp("foodGroup")]
public EFoodGroup FoodGroup { get; set;}

[REDProp("attractionRange")]
public float AttractionRange { get; set;}

[REDProp("deadAttractionRange")]
public float DeadAttractionRange { get; set;}

[REDProp("bleedingAttractionRange")]
public float BleedingAttractionRange { get; set;}

#endregion
}
}