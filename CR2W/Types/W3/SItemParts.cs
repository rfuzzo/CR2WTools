using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class SItemParts 
{
#region RED Properties

[REDProp("itemName")]
public CName ItemName { get; set;}

[REDProp("quantity")]
public int Quantity { get; set;}

#endregion
}
}