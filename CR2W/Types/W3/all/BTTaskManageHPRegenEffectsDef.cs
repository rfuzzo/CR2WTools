using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class BTTaskManageHPRegenEffectsDef : IBehTreeTaskDefinition
{
#region RED Properties

[REDProp("ResumeEffect")]
public bool ResumeEffect { get; set;}

[REDProp("OnDeactivate")]
public bool OnDeactivate { get; set;}

#endregion
}
}