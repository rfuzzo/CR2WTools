using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class SGraphLayer 
{
#region RED Properties

[REDProp("state")]
public EGraphLayerState State { get; set;}

[REDProp("name")]
public string Name { get; set;}

#endregion
}
}