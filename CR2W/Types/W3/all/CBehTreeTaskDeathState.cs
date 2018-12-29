using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBehTreeTaskDeathState : IBehTreeTask
{
#region RED Properties

[REDProp("destroyAfterAnimDelay")]
public float DestroyAfterAnimDelay { get; set;}

[REDProp("destroyAnimEvent")]
public bool DestroyAnimEvent { get; set;}

[REDProp("fxName")]
public CName FxName { get; set;}

[REDProp("setAppearanceTo")]
public CName SetAppearanceTo { get; set;}

[REDProp("createReactionEvent")]
public CName CreateReactionEvent { get; set;}

[REDProp("changeAppearanceAfter")]
public float ChangeAppearanceAfter { get; set;}

[REDProp("saveLockID")]
public Int32 SaveLockID { get; set;}

[REDProp("dropWeapons")]
public bool DropWeapons { get; set;}

[REDProp("deadDestructSquaredDist")]
public float DeadDestructSquaredDist { get; set;}

#endregion
}
}