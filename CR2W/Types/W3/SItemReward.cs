using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class SItemReward 
{
#region RED Properties

[REDProp("item")]
public CName Item { get; set;}

[REDProp("amount")]
public int Amount { get; set;}

#endregion
}
}