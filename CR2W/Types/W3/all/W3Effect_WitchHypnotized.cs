using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3Effect_WitchHypnotized : W3CriticalEffect
{
#region RED Properties

[REDProp("customCameraStackIndex")]
public Int32 CustomCameraStackIndex { get; set;}

[REDProp("fxEntity")]
public Handle<CEntity> FxEntity { get; set;}

[REDProp("envID")]
public Int32 EnvID { get; set;}

#endregion
}
}