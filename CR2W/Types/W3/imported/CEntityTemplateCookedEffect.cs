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
public class CEntityTemplateCookedEffect 
{
#region RED Properties

[REDProp("name")]
public CName Name { get; set;}

[REDProp("animName")]
public CName AnimName { get; set;}

[REDProp("buffer")]
public SharedDataBuffer Buffer { get; set;}

#endregion
}
}