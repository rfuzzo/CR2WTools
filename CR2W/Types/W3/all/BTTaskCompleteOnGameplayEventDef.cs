using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class BTTaskCompleteOnGameplayEventDef : IBehTreeTaskDefinition
{
#region RED Properties

[REDProp("gameplayEvent")]
public CName GameplayEvent { get; set;}

[REDProp("sucess")]
public bool Sucess { get; set;}

#endregion
}
}