using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class SIngredientCategoryElement 
{
#region RED Properties

[REDProp("name")]
public CName Name { get; set;}

[REDProp("priority")]
public uint Priority { get; set;}

#endregion
}
}