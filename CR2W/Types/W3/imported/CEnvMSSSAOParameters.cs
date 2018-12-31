using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using CR2W.IO;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CEnvMSSSAOParameters 
{
#region RED Properties

[REDProp("activated")]
public bool Activated { get; set;}

[REDProp("noiseFilterTolerance")]
public SSimpleCurve NoiseFilterTolerance { get; set;}

[REDProp("blurTolerance")]
public SSimpleCurve BlurTolerance { get; set;}

[REDProp("upsampleTolerance")]
public SSimpleCurve UpsampleTolerance { get; set;}

[REDProp("rejectionFalloff")]
public SSimpleCurve RejectionFalloff { get; set;}

[REDProp("combineResolutionsBeforeBlur")]
public bool CombineResolutionsBeforeBlur { get; set;}

[REDProp("combineResolutionsWithMul")]
public bool CombineResolutionsWithMul { get; set;}

[REDProp("hierarchyDepth")]
public SSimpleCurve HierarchyDepth { get; set;}

[REDProp("normalAOMultiply")]
public SSimpleCurve NormalAOMultiply { get; set;}

[REDProp("normalToDepthBrightnessEqualiser")]
public SSimpleCurve NormalToDepthBrightnessEqualiser { get; set;}

[REDProp("normalBackProjectionTolerance")]
public SSimpleCurve NormalBackProjectionTolerance { get; set;}

#endregion
}
}