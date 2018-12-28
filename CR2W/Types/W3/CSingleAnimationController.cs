using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
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