using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class CLocalizedContent : CObject
{
#region RED Properties

[REDProp("index")]
public uint Index { get; set;}

#endregion
}
}