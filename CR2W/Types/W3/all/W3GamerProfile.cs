using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3GamerProfile : CObject
{
#region RED Properties

[REDProp("statistics")]
public Array<SStatistic> Statistics { get; set;}

[REDProp("achievementDefinitions")]
public Array<SAchievement> AchievementDefinitions { get; set;}

#endregion
}
}