using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class SGameplayEventParamObject 
{
#region RED Properties

[REDProp("value")]
public Handle<IScriptable> Value { get; set;}

#endregion
}
}