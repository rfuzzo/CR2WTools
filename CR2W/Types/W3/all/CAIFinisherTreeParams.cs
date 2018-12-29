using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CAIFinisherTreeParams : CAICombatActionParameters
{
#region RED Properties

[REDProp("syncAnimName")]
public CName SyncAnimName { get; set;}

#endregion
}
}