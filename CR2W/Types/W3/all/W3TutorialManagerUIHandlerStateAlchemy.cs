using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3TutorialManagerUIHandlerStateAlchemy : W3TutorialManagerUIHandlerStateTutHandlerBaseState
{
#region RED Properties

[REDProp("INGREDIENTS")]
public CName INGREDIENTS { get; set;}

[REDProp("COOKED_ITEM_DESC")]
public CName COOKED_ITEM_DESC { get; set;}

[REDProp("CATEGORIES")]
public CName CATEGORIES { get; set;}

[REDProp("SELECT_SOMETHING")]
public CName SELECT_SOMETHING { get; set;}

[REDProp("SELECT_THUNDERBOLT")]
public CName SELECT_THUNDERBOLT { get; set;}

[REDProp("COOK")]
public CName COOK { get; set;}

[REDProp("POTIONS")]
public CName POTIONS { get; set;}

[REDProp("PREPARATION_GO_TO")]
public CName PREPARATION_GO_TO { get; set;}

[REDProp("RECIPE_THUNDERBOLT")]
public CName RECIPE_THUNDERBOLT { get; set;}

[REDProp("POTIONS_JOURNAL")]
public CName POTIONS_JOURNAL { get; set;}

[REDProp("isClosing")]
public bool IsClosing { get; set;}

[REDProp("isForcedTunderbolt")]
public bool IsForcedTunderbolt { get; set;}

[REDProp("currentlySelectedRecipe")]
public CName CurrentlySelectedRecipe { get; set;}

[REDProp("requiredRecipeName")]
public CName RequiredRecipeName { get; set;}

[REDProp("selectRecipe")]
public CName SelectRecipe { get; set;}

#endregion
}
}