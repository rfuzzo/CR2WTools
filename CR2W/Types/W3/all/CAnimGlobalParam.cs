using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CAnimGlobalParam : CEntityTemplateParam
{
#region RED Properties

[REDProp("wasIncluded")]
public bool WasIncluded { get; set;}

[REDProp("skeletonType")]
public ESkeletonType SkeletonType { get; set;}

[REDProp("defaultAnimationName")]
public CName DefaultAnimationName { get; set;}

[REDProp("customMimicsFilter_Full")]
public CName CustomMimicsFilter_Full { get; set;}

[REDProp("customMimicsFilter_Lipsync")]
public CName CustomMimicsFilter_Lipsync { get; set;}

[REDProp("animTag")]
public CName AnimTag { get; set;}

[REDProp("sfxTag")]
public CName SfxTag { get; set;}

#endregion
}
}