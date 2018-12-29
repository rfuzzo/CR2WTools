using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class CQuestPhase : CResource
{
#region RED Properties

[REDProp("graph")]
public Ptr<CQuestGraph> Graph { get; set;}

#endregion
}
}