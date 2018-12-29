using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CR4MainGammaMenu : CR4MenuBase
{
#region RED Properties

[REDProp("mInGameConfigWrapper")]
public Handle<CInGameConfigWrapper> MInGameConfigWrapper { get; set;}

[REDProp("m_fxSetCurrentUsername")]
public Handle<CScriptedFlashFunction> M_fxSetCurrentUsername { get; set;}

#endregion
}
}