using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CArchesporeAICombatStorage : IScriptable
{
#region RED Properties

[REDProp("myBaseEntities")]
public Array<Handle<CGameplayEntity>> MyBaseEntities { get; set;}

[REDProp("noBulbAreas")]
public Array<Handle<CAreaComponent>> NoBulbAreas { get; set;}

[REDProp("currentlyUsedBase")]
public Handle<CGameplayEntity> CurrentlyUsedBase { get; set;}

[REDProp("wasInitialized")]
public bool WasInitialized { get; set;}

[REDProp("manualBulbCleanup")]
public bool ManualBulbCleanup { get; set;}

#endregion
}
}