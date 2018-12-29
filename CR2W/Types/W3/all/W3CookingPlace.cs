using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3CookingPlace : W3Container
{
#region RED Properties

[REDProp("cookingTime")]
public float CookingTime { get; set;}

[REDProp("schematics")]
public Array<SCookingSchematic> Schematics { get; set;}

[REDProp("isActive")]
public bool IsActive { get; set;}

[REDProp("cookingStarted")]
public bool CookingStarted { get; set;}

[REDProp("cookingCompleted")]
public bool CookingCompleted { get; set;}

[REDProp("secondaryLootInteractionComponent")]
public Handle<CInteractionComponent> SecondaryLootInteractionComponent { get; set;}

#endregion
}
}