using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskScaredWhileSitting : CBTTaskShouldBeScaredOnOverlay
{
#region RED Properties

[REDProp("leftItem")]
public Handle<CDrawableComponent> LeftItem { get; set;}

[REDProp("rightItem")]
public Handle<CDrawableComponent> RightItem { get; set;}

[REDProp("entity")]
public Handle<CEntity> Entity { get; set;}

#endregion
}
}