using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class SLensFlareGroupsParameters 
{
#region RED Properties

[REDProp("default")]
public SLensFlareParameters Default { get; set;}

[REDProp("sun")]
public SLensFlareParameters Sun { get; set;}

[REDProp("moon")]
public SLensFlareParameters Moon { get; set;}

[REDProp("custom0")]
public SLensFlareParameters Custom0 { get; set;}

[REDProp("custom1")]
public SLensFlareParameters Custom1 { get; set;}

[REDProp("custom2")]
public SLensFlareParameters Custom2 { get; set;}

[REDProp("custom3")]
public SLensFlareParameters Custom3 { get; set;}

[REDProp("custom4")]
public SLensFlareParameters Custom4 { get; set;}

[REDProp("custom5")]
public SLensFlareParameters Custom5 { get; set;}

#endregion
}
}