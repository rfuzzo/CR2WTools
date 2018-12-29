using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class BTTaskManageSplashEffect : IBehTreeTask
{
#region RED Properties

[REDProp("m_SplashEntityTemplate")]
public Handle<CEntityTemplate> M_SplashEntityTemplate { get; set;}

[REDProp("m_PreviousDistanceFromSurface")]
public float M_PreviousDistanceFromSurface { get; set;}

[REDProp("m_CrossedOnce")]
public bool M_CrossedOnce { get; set;}

[REDProp("couldntLoadResource")]
public bool CouldntLoadResource { get; set;}

#endregion
}
}