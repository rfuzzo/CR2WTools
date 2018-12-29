using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3MerchantNPC : CNewNPC
{
#region RED Properties

[REDProp("embeddedScenes")]
public Array<MerchantNPCEmbeddedScenes> EmbeddedScenes { get; set;}

[REDProp("lastDayOfInteraction")]
public Int32 LastDayOfInteraction { get; set;}

[REDProp("questBonus")]
public bool QuestBonus { get; set;}

[REDProp("cacheMerchantMappin")]
public bool CacheMerchantMappin { get; set;}

[REDProp("craftingDisabled")]
public bool CraftingDisabled { get; set;}

[REDProp("invComp")]
public Handle<CInventoryComponent> InvComp { get; set;}

#endregion
}
}