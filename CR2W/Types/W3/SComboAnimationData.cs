using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class SComboAnimationData 
{
#region RED Properties

[REDProp("animationName")]
public CName AnimationName { get; set;}

[REDProp("blendIn")]
public float BlendIn { get; set;}

[REDProp("blendOut")]
public float BlendOut { get; set;}

#endregion
}
}