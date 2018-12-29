using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class SIngredientCategory 
{
#region RED Properties

[REDProp("name")]
public CName Name { get; set;}

[REDProp("specified")]
public bool Specified { get; set;}

#endregion
}
}