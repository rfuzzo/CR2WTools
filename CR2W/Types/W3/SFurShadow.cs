using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class SFurShadow 
{
#region RED Properties

[REDProp("shadowSigma")]
public float ShadowSigma { get; set;}

[REDProp("shadowDensityScale")]
public float ShadowDensityScale { get; set;}

[REDProp("castShadows")]
public bool CastShadows { get; set;}

[REDProp("receiveShadows")]
public bool ReceiveShadows { get; set;}

#endregion
}
}