using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class CQuestGraph : CObject
{
#region RED Properties

[REDProp("graphBlocks")]
public Array<Ptr<CGraphBlock>> GraphBlocks { get; set;}

[REDProp("sourceDataRemoved")]
public bool SourceDataRemoved { get; set;}

[REDProp("isTest")]
public bool IsTest { get; set;}

#endregion
}
}