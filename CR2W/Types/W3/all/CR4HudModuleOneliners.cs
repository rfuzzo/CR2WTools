using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CR4HudModuleOneliners : CR4HudModuleBase
{
#region RED Properties

[REDProp("m_hud")]
public Handle<CR4ScriptedHud> M_hud { get; set;}

[REDProp("m_fxCreateOnelinerSFF")]
public Handle<CScriptedFlashFunction> M_fxCreateOnelinerSFF { get; set;}

[REDProp("m_fxRemoveOnelinerSFF")]
public Handle<CScriptedFlashFunction> M_fxRemoveOnelinerSFF { get; set;}

[REDProp("m_flashModule")]
public Handle<CScriptedFlashSprite> M_flashModule { get; set;}

[REDProp("m_oneliners")]
public Array<OnelinerDefinition> M_oneliners { get; set;}

[REDProp("VISIBILITY_DISTANCE_SQUARED")]
public float VISIBILITY_DISTANCE_SQUARED { get; set;}

#endregion
}
}