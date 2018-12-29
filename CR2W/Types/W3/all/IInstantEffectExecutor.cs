using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class IInstantEffectExecutor : IGameplayEffectExecutor
{
#region RED Properties

[REDProp("customIconPath")]
public string CustomIconPath { get; set;}

[REDProp("customNameLocalisationKey")]
public string CustomNameLocalisationKey { get; set;}

[REDProp("customDescriptionLocalisationKey")]
public string CustomDescriptionLocalisationKey { get; set;}

[REDProp("executorName")]
public CName ExecutorName { get; set;}

#endregion
}
}