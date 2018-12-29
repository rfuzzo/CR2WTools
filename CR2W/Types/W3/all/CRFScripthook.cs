using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CRFScripthook : CEntity
{
#region RED Properties

[REDProp("offset")]
public float Offset { get; set;}

[REDProp("rotOffset")]
public float RotOffset { get; set;}

[REDProp("modelnames")]
public Array<string> Modelnames { get; set;}

[REDProp("currentnameNo")]
public Int32 CurrentnameNo { get; set;}

[REDProp("testvar")]
public string Testvar { get; set;}

#endregion
}
}