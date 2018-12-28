using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class SFurGlint 
{
#region RED Properties

[REDProp("glintStrength")]
public float GlintStrength { get; set;}

[REDProp("glintCount")]
public float GlintCount { get; set;}

[REDProp("glintExponent")]
public float GlintExponent { get; set;}

#endregion
}
}