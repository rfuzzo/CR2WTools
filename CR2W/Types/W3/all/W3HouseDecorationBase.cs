using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3HouseDecorationBase : W3Container
{
#region RED Properties

[REDProp("m_popupData")]
public Handle<W3ItemSelectionPopupData> M_popupData { get; set;}

[REDProp("m_itemSelectionTagList")]
public Array<CName> M_itemSelectionTagList { get; set;}

[REDProp("m_itemSelectionForbiddenTagList")]
public Array<CName> M_itemSelectionForbiddenTagList { get; set;}

[REDProp("m_itemSelectionMode")]
public EItemSelectionPopupMode M_itemSelectionMode { get; set;}

[REDProp("m_itemSelectionCategories")]
public Array<CName> M_itemSelectionCategories { get; set;}

[REDProp("m_acceptQuestItems")]
public bool M_acceptQuestItems { get; set;}

[REDProp("m_decorationEnabled")]
public bool M_decorationEnabled { get; set;}

[REDProp("m_noItemMessageStringKey")]
public CName M_noItemMessageStringKey { get; set;}

#endregion
}
}