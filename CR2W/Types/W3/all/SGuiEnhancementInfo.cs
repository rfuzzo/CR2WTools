using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class SGuiEnhancementInfo 
{
#region RED Properties

[REDProp("enhancedItem")]
public CName EnhancedItem { get; set;}

[REDProp("enhancement")]
public CName Enhancement { get; set;}

[REDProp("oilItem")]
public CName OilItem { get; set;}

[REDProp("oil")]
public CName Oil { get; set;}

[REDProp("dyeItem")]
public CName DyeItem { get; set;}

[REDProp("dye")]
public CName Dye { get; set;}

[REDProp("dyeColor")]
public int DyeColor { get; set;}

#endregion
}
}