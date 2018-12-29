using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3Bird : CGameplayEntity
{
#region RED Properties

[REDProp("flyingAppearanceName")]
public CName FlyingAppearanceName { get; set;}

[REDProp("destroyDistance")]
public float DestroyDistance { get; set;}

[REDProp("flyCurves")]
public Array<CName> FlyCurves { get; set;}

[REDProp("manager")]
public Handle<CBirdsManager> Manager { get; set;}

#endregion
}
}