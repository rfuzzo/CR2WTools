using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CAINpcDeathParams : CAIDeathParameters
{
#region RED Properties

[REDProp("createReactionEvent")]
public CName CreateReactionEvent { get; set;}

[REDProp("fxName")]
public CName FxName { get; set;}

[REDProp("playFXOnActivate")]
public CName PlayFXOnActivate { get; set;}

[REDProp("playFXOnDeactivate")]
public CName PlayFXOnDeactivate { get; set;}

[REDProp("stopFXOnActivate")]
public CName StopFXOnActivate { get; set;}

[REDProp("stopFXOnDeactivate")]
public CName StopFXOnDeactivate { get; set;}

[REDProp("playSFXOnActivate")]
public CName PlaySFXOnActivate { get; set;}

[REDProp("setAppearanceTo")]
public CName SetAppearanceTo { get; set;}

[REDProp("changeAppearanceAfter")]
public float ChangeAppearanceAfter { get; set;}

[REDProp("disableAgony")]
public bool DisableAgony { get; set;}

[REDProp("disableCollision")]
public bool DisableCollision { get; set;}

[REDProp("disableCollisionDelay")]
public float DisableCollisionDelay { get; set;}

[REDProp("disableCollisionOnAnim")]
public bool DisableCollisionOnAnim { get; set;}

[REDProp("disableCollisionOnAnimDelay")]
public float DisableCollisionOnAnimDelay { get; set;}

[REDProp("destroyAfterAnimDelay")]
public float DestroyAfterAnimDelay { get; set;}

[REDProp("disableRagdollAfter")]
public float DisableRagdollAfter { get; set;}

#endregion
}
}