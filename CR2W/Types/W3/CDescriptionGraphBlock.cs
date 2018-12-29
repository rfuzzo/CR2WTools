using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class CDescriptionGraphBlock : CGraphHelperBlock
{
#region RED Properties

[REDProp("sockets")]
public Array<Ptr<CGraphSocket>> Sockets { get; set;}

[REDProp("size")]
public Vector Size { get; set;}

[REDProp("caption")]
public string Caption { get; set;}

[REDProp("descriptionText")]
public string DescriptionText { get; set;}

#endregion
}
}