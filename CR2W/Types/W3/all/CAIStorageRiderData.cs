using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CAIStorageRiderData : IScriptable
{
#region RED Properties

[REDProp("sharedParams")]
public Handle<CHorseRiderSharedParams> SharedParams { get; set;}

[REDProp("ridingManagerMountError")]
public bool RidingManagerMountError { get; set;}

[REDProp("ridingManagerCurrentTask")]
public ERidingManagerTask RidingManagerCurrentTask { get; set;}

[REDProp("horseScriptedActionTree")]
public Handle<IAIActionTree> HorseScriptedActionTree { get; set;}

[REDProp("ridingManagerDismountType")]
public EDismountType RidingManagerDismountType { get; set;}

[REDProp("ridingManagerInstantMount")]
public bool RidingManagerInstantMount { get; set;}

#endregion
}
}