using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskPlayAnimationEventDecoratorDef : IBehTreeTaskDefinition
{
#region RED Properties

[REDProp("finishTaskOnAllowBlend")]
public bool FinishTaskOnAllowBlend { get; set;}

[REDProp("rotateOnRotateEvent")]
public bool RotateOnRotateEvent { get; set;}

[REDProp("disableHitOnActivation")]
public bool DisableHitOnActivation { get; set;}

[REDProp("disableLookatOnActivation")]
public bool DisableLookatOnActivation { get; set;}

[REDProp("interruptOverlayAnim")]
public bool InterruptOverlayAnim { get; set;}

[REDProp("checkStats")]
public bool CheckStats { get; set;}

[REDProp("xmlMoraleCheckName")]
public CName XmlMoraleCheckName { get; set;}

[REDProp("xmlStaminaCostName")]
public CName XmlStaminaCostName { get; set;}

[REDProp("drainStaminaOnUse")]
public bool DrainStaminaOnUse { get; set;}

[REDProp("completeTaskOnRotateEnd")]
public bool CompleteTaskOnRotateEnd { get; set;}

[REDProp("useCombatTargetForRotation")]
public bool UseCombatTargetForRotation { get; set;}

[REDProp("setIsImportantAnim")]
public bool SetIsImportantAnim { get; set;}

#endregion
}
}