using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3LeaderboardCustom : W3Poster
{
#region RED Properties

[REDProp("m_competitors")]
public Array<SLeaderBoardData> M_competitors { get; set;}

[REDProp("m_pointSymbolStringKey")]
public string M_pointSymbolStringKey { get; set;}

[REDProp("m_displayPointsNumerically")]
public bool M_displayPointsNumerically { get; set;}

[REDProp("m_bottom_padding")]
public Int32 M_bottom_padding { get; set;}

[REDProp("m_left_padding")]
public Int32 M_left_padding { get; set;}

#endregion
}
}