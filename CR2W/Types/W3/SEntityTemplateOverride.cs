using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class SEntityTemplateOverride 
{
#region RED Properties

[REDProp("componentName")]
public CName ComponentName { get; set;}

[REDProp("className")]
public CName ClassName { get; set;}

[REDProp("overriddenProperties")]
public Array<CName> OverriddenProperties { get; set;}

#endregion
}
}