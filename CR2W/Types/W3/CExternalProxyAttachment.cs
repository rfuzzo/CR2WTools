using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class CExternalProxyAttachment : IAttachment
{
#region RED Properties

[REDProp("parent")]
public Ptr<CNode> Parent { get; set;}

[REDProp("child")]
public Ptr<CNode> Child { get; set;}

[REDProp("isBroken")]
public bool IsBroken { get; set;}

[REDProp("originalAttachment")]
public Ptr<IAttachment> OriginalAttachment { get; set;}

#endregion
}
}