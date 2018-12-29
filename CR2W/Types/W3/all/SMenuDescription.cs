using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class SMenuDescription 
{
#region RED Properties

[REDProp("menuName")]
public CName MenuName { get; set;}

[REDProp("menuResource")]
public Soft<CMenuResource> MenuResource { get; set;}

#endregion
}
}