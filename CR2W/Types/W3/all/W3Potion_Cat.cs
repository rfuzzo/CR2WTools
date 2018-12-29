using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3Potion_Cat : CBaseGameplayEffect
{
#region RED Properties

[REDProp("highlightObjectsRange")]
public float HighlightObjectsRange { get; set;}

[REDProp("highlightEnemiesRange")]
public float HighlightEnemiesRange { get; set;}

[REDProp("witcher")]
public Handle<W3PlayerWitcher> Witcher { get; set;}

[REDProp("isScreenFxActive")]
public bool IsScreenFxActive { get; set;}

[REDProp("timeSinceLastHighlight")]
public float TimeSinceLastHighlight { get; set;}

[REDProp("timeSinceLastEnemyHighlight")]
public float TimeSinceLastEnemyHighlight { get; set;}

[REDProp("HIGHLIGHT_REFRESH_DT")]
public float HIGHLIGHT_REFRESH_DT { get; set;}

[REDProp("ENEMY_HIGHLIGHT_DT")]
public float ENEMY_HIGHLIGHT_DT { get; set;}

#endregion
}
}