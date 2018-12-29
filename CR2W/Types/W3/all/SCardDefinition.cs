using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class SCardDefinition 
{
#region RED Properties

[REDProp("index")]
public int Index { get; set;}

[REDProp("title")]
public string Title { get; set;}

[REDProp("description")]
public string Description { get; set;}

[REDProp("power")]
public int Power { get; set;}

[REDProp("picture")]
public string Picture { get; set;}

[REDProp("faction")]
public eGwintFaction Faction { get; set;}

[REDProp("typeFlags")]
public int TypeFlags { get; set;}

[REDProp("effectFlags")]
public Array<eGwintEffect> EffectFlags { get; set;}

[REDProp("summonFlags")]
public Array<Int32> SummonFlags { get; set;}

[REDProp("dlcPictureFlag")]
public CName DlcPictureFlag { get; set;}

[REDProp("dlcPicture")]
public string DlcPicture { get; set;}

#endregion
}
}