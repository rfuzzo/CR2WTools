using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3SE_EnableTreasureHuntMappin : W3SwitchEvent
{
#region RED Properties

[REDProp("mappinEntityTag")]
public CName MappinEntityTag { get; set;}

[REDProp("enable")]
public bool Enable { get; set;}

[REDProp("mappinEntity")]
public Handle<W3TreasureHuntMappinEntity> MappinEntity { get; set;}

[REDProp("commonMapManager")]
public Handle<CCommonMapManager> CommonMapManager { get; set;}

#endregion
}
}