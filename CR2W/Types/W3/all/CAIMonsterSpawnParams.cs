using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CAIMonsterSpawnParams : CAISubTreeParameters
{
#region RED Properties

[REDProp("fxName")]
public CName FxName { get; set;}

[REDProp("animEventNameActivator")]
public CName AnimEventNameActivator { get; set;}

[REDProp("playFXOnAnimEvent")]
public bool PlayFXOnAnimEvent { get; set;}

[REDProp("monitorGroundContact")]
public bool MonitorGroundContact { get; set;}

[REDProp("dealDamageOnAnimEvent")]
public CName DealDamageOnAnimEvent { get; set;}

[REDProp("becomeVisibleOnAnimEvent")]
public CName BecomeVisibleOnAnimEvent { get; set;}

#endregion
}
}