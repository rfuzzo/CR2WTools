using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class SCharacterWindParams 
{
#region RED Properties

[REDProp("primaryDensity")]
public float PrimaryDensity { get; set;}

[REDProp("secondaryDensity")]
public float SecondaryDensity { get; set;}

[REDProp("primaryOscilationFrequency")]
public float PrimaryOscilationFrequency { get; set;}

[REDProp("secondaryOscilationFrequency")]
public float SecondaryOscilationFrequency { get; set;}

[REDProp("primaryDistance")]
public float PrimaryDistance { get; set;}

[REDProp("secondaryDistance")]
public float SecondaryDistance { get; set;}

[REDProp("gustFrequency")]
public float GustFrequency { get; set;}

[REDProp("gustDistance")]
public float GustDistance { get; set;}

#endregion
}
}