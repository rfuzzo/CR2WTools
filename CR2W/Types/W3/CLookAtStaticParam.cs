using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CLookAtStaticParam : CEntityTemplateParam
{
#region RED Properties

[REDProp("wasIncluded")]
public bool WasIncluded { get; set;}

[REDProp("maxLookAtLevel")]
public ELookAtLevel MaxLookAtLevel { get; set;}

[REDProp("maxHorAngle")]
public float MaxHorAngle { get; set;}

[REDProp("maxVerAngle")]
public float MaxVerAngle { get; set;}

[REDProp("secWeight")]
public float SecWeight { get; set;}

[REDProp("firstWeight")]
public float FirstWeight { get; set;}

[REDProp("responsiveness")]
public float Responsiveness { get; set;}

#endregion
}
}