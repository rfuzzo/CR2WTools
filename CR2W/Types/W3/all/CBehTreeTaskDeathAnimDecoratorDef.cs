using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBehTreeTaskDeathAnimDecoratorDef : IBehTreeTaskDefinition
{
#region RED Properties

[REDProp("completeTimer")]
public float CompleteTimer { get; set;}

[REDProp("disableCollisionOnAnim")]
public CBehTreeValBool DisableCollisionOnAnim { get; set;}

[REDProp("disableCollisionOnAnimDelay")]
public CBehTreeValFloat DisableCollisionOnAnimDelay { get; set;}

[REDProp("stopFXOnActivate")]
public CBehTreeValCName StopFXOnActivate { get; set;}

[REDProp("stopFXOnDeactivate")]
public CBehTreeValCName StopFXOnDeactivate { get; set;}

[REDProp("playFXOnActivate")]
public CBehTreeValCName PlayFXOnActivate { get; set;}

[REDProp("playFXOnDeactivate")]
public CBehTreeValCName PlayFXOnDeactivate { get; set;}

[REDProp("playSFXOnActivate")]
public CBehTreeValCName PlaySFXOnActivate { get; set;}

#endregion
}
}