using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CComponentReference 
{
#region RED Properties

[REDProp("name")]
public string Name { get; set;}

[REDProp("className")]
public CName ClassName { get; set;}

#endregion
}
}