using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CStorySceneActorPosition 
{
#region RED Properties

[REDProp("position")]
public TagList Position { get; set;}

[REDProp("distance")]
public float Distance { get; set;}

[REDProp("useRotation")]
public bool UseRotation { get; set;}

[REDProp("performAction")]
public EStoryScenePerformActionMode PerformAction { get; set;}

#endregion
}
}