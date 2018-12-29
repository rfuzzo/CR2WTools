using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class BTTaskManageMistFormDef : CBTTaskPlayAnimationEventDecoratorDef
{
#region RED Properties

[REDProp("enableOnActivate")]
public bool EnableOnActivate { get; set;}

[REDProp("enableOnMain")]
public bool EnableOnMain { get; set;}

[REDProp("disableOnDeactivate")]
public bool DisableOnDeactivate { get; set;}

[REDProp("affectVisibility")]
public bool AffectVisibility { get; set;}

[REDProp("affectGameplayVisibility")]
public bool AffectGameplayVisibility { get; set;}

[REDProp("affectCollision")]
public bool AffectCollision { get; set;}

[REDProp("affectHitAnims")]
public bool AffectHitAnims { get; set;}

[REDProp("affectImmortality")]
public bool AffectImmortality { get; set;}

[REDProp("delayExecutionInMain")]
public float DelayExecutionInMain { get; set;}

[REDProp("appearanceOnActivate")]
public CName AppearanceOnActivate { get; set;}

[REDProp("appearanceOnMain")]
public CName AppearanceOnMain { get; set;}

[REDProp("restoreAppearanceOnDeactivate")]
public bool RestoreAppearanceOnDeactivate { get; set;}

[REDProp("appearanceOnDeactivate")]
public CName AppearanceOnDeactivate { get; set;}

#endregion
}
}