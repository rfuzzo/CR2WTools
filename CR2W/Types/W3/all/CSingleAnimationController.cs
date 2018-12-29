using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CSingleAnimationController : IAnimationController
{
#region RED Properties

[REDProp("collectEvents")]
public bool CollectEvents { get; set;}

[REDProp("animationName")]
public CName AnimationName { get; set;}

#endregion
}
}