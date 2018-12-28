using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CDaytimeCondition : ISpawnCondition
{
#region RED Properties

[REDProp("begin")]
public GameTime Begin { get; set;}

[REDProp("end")]
public GameTime End { get; set;}

#endregion
}
}