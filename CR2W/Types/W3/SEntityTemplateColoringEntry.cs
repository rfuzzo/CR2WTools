using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class SEntityTemplateColoringEntry 
{
#region RED Properties

[REDProp("appearance")]
public CName Appearance { get; set;}

[REDProp("componentName")]
public CName ComponentName { get; set;}

[REDProp("colorShift1")]
public CColorShift ColorShift1 { get; set;}

[REDProp("colorShift2")]
public CColorShift ColorShift2 { get; set;}

#endregion
}
}