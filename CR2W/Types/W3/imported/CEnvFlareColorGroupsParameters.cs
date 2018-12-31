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
public class CEnvFlareColorGroupsParameters 
{
#region RED Properties

[REDProp("activated")]
public bool Activated { get; set;}

[REDProp("default")]
public CEnvFlareColorParameters Default { get; set;}

[REDProp("custom0")]
public CEnvFlareColorParameters Custom0 { get; set;}

[REDProp("custom1")]
public CEnvFlareColorParameters Custom1 { get; set;}

[REDProp("custom2")]
public CEnvFlareColorParameters Custom2 { get; set;}

#endregion
}
}