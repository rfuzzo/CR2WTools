using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CR4ListBaseMenu : CR4MenuBase
{
#region RED Properties

[REDProp("DATA_BINDING_NAME")]
public string DATA_BINDING_NAME { get; set;}

[REDProp("DATA_BINDING_NAME_SUBLIST")]
public string DATA_BINDING_NAME_SUBLIST { get; set;}

[REDProp("DATA_BINDING_NAME_DESCRIPTION")]
public string DATA_BINDING_NAME_DESCRIPTION { get; set;}

[REDProp("ITEMS_SIZE")]
public Int32 ITEMS_SIZE { get; set;}

[REDProp("m_journalManager")]
public Handle<CWitcherJournalManager> M_journalManager { get; set;}

[REDProp("currentTag")]
public CName CurrentTag { get; set;}

[REDProp("lastSentTag")]
public CName LastSentTag { get; set;}

[REDProp("openedTabs")]
public Array<CName> OpenedTabs { get; set;}

[REDProp("itemsNames")]
public Array<CName> ItemsNames { get; set;}

#endregion
}
}