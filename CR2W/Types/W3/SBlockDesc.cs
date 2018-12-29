using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class SBlockDesc 
{
#region RED Properties

[REDProp("ock")]
public Ptr<CQuestGraphBlock> Ock { get; set;}

[REDProp("putName")]
public CName PutName { get; set;}

#endregion
}
}