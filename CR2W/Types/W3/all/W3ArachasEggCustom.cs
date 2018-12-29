using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3ArachasEggCustom : W3MonsterClue
{
#region RED Properties

[REDProp("morphTimeIgni")]
public float MorphTimeIgni { get; set;}

[REDProp("morphTimeAard")]
public float MorphTimeAard { get; set;}

[REDProp("burnoutTime")]
public float BurnoutTime { get; set;}

[REDProp("destroyed")]
public bool Destroyed { get; set;}

[REDProp("igniReactionEffect")]
public CName IgniReactionEffect { get; set;}

[REDProp("aardReactionEffect")]
public CName AardReactionEffect { get; set;}

[REDProp("onDestroyedFact")]
public Array<CName> OnDestroyedFact { get; set;}

[REDProp("morphManager")]
public Handle<CMorphedMeshManagerComponent> MorphManager { get; set;}

[REDProp("morphTime")]
public float MorphTime { get; set;}

[REDProp("allowFactAdding")]
public bool AllowFactAdding { get; set;}

[REDProp("APPEARANCE_INTACT")]
public CName APPEARANCE_INTACT { get; set;}

[REDProp("APPEARANCE_DESTROYED")]
public CName APPEARANCE_DESTROYED { get; set;}

#endregion
}
}