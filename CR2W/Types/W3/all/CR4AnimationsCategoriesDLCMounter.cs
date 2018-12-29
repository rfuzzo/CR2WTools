using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CR4AnimationsCategoriesDLCMounter : IGameplayDLCMounter
{
#region RED Properties

[REDProp("animationsCategoriesTableFilePath")]
public string AnimationsCategoriesTableFilePath { get; set;}

#endregion
}
}