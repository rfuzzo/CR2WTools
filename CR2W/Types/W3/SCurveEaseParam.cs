using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class SCurveEaseParam 
{
#region RED Properties

[REDProp("easeIn")]
public float EaseIn { get; set;}

[REDProp("easeOut")]
public float EaseOut { get; set;}

#endregion
}
}