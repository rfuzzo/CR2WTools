using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class SCustomMapPinDefinition 
{
#region RED Properties

[REDProp("tag")]
public CName Tag { get; set;}

[REDProp("type")]
public CName Type { get; set;}

#endregion
}
}