using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3TutorialManagerUIHandlerStateAlchemyMutagens : W3TutorialManagerUIHandlerStateTutHandlerBaseState
{
#region RED Properties

[REDProp("MUTAGENS")]
public CName MUTAGENS { get; set;}

[REDProp("currentlySelectedRecipe")]
public CName CurrentlySelectedRecipe { get; set;}

[REDProp("requiredRecipeName")]
public CName RequiredRecipeName { get; set;}

[REDProp("selectRecipe")]
public CName SelectRecipe { get; set;}

#endregion
}
}