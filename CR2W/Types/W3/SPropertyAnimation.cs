using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class SPropertyAnimation 
{
#region RED Properties

[REDProp("propertyName")]
public CName PropertyName { get; set;}

[REDProp("animationName")]
public CName AnimationName { get; set;}

[REDProp("curve")]
public SMultiCurve Curve { get; set;}

[REDProp("playOnStartup")]
public bool PlayOnStartup { get; set;}

[REDProp("effectToPlay")]
public CName EffectToPlay { get; set;}

#endregion
}
}