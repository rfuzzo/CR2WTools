using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3TutorialManagerUIHandlerStateCrafting : W3TutorialManagerUIHandlerStateTutHandlerBaseState
{
#region RED Properties

[REDProp("SCHEMATICS")]
public CName SCHEMATICS { get; set;}

[REDProp("ITEM_DESCRIPTION")]
public CName ITEM_DESCRIPTION { get; set;}

[REDProp("COMPONENTS")]
public CName COMPONENTS { get; set;}

[REDProp("PRICE")]
public CName PRICE { get; set;}

[REDProp("CRAFTSMEN")]
public CName CRAFTSMEN { get; set;}

[REDProp("DISMANTLING")]
public CName DISMANTLING { get; set;}

[REDProp("isClosing")]
public bool IsClosing { get; set;}

#endregion
}
}