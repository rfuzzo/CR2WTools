using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3CreaturesGroupEnabledCondition : ISpawnScriptCondition
{
#region RED Properties

[REDProp("groupName")]
public CName GroupName { get; set;}

[REDProp("disabledBySources")]
public Int32 DisabledBySources { get; set;}

[REDProp("dataManager")]
public Handle<CEncounterDataManager> DataManager { get; set;}

#endregion
}
}