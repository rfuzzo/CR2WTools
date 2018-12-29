using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class ISpawnAnimEntityInitializer : ISpawnTreeScriptedInitializer
{
#region RED Properties

[REDProp("forceSpawnAnim")]
public Int32 ForceSpawnAnim { get; set;}

#endregion
}
}