using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3LevelManager : CObject
{
#region RED Properties

[REDProp("owner")]
public Handle<W3PlayerWitcher> Owner { get; set;}

[REDProp("levelDefinitions")]
public Array<SLevelDefinition> LevelDefinitions { get; set;}

[REDProp("level")]
public Int32 Level { get; set;}

[REDProp("points")]
public Array<SSpendablePoints> Points { get; set;}

[REDProp("lastCustomLevel")]
public Int32 LastCustomLevel { get; set;}

#endregion
}
}