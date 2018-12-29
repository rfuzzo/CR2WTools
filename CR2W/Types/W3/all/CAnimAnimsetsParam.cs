using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CAnimAnimsetsParam : CEntityTemplateParam
{
#region RED Properties

[REDProp("wasIncluded")]
public bool WasIncluded { get; set;}

[REDProp("name")]
public string Name { get; set;}

[REDProp("componentName")]
public string ComponentName { get; set;}

[REDProp("animationSets")]
public Array<Handle<CSkeletalAnimationSet>> AnimationSets { get; set;}

#endregion
}
}