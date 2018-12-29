using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3TutorialManagerUIHandlerStateBestiaryGlossarySubmenu : W3TutorialManagerUIHandlerStateTutHandlerBaseState
{
#region RED Properties

[REDProp("OPEN_GLOSSARY")]
public CName OPEN_GLOSSARY { get; set;}

[REDProp("OPEN_BESTIARY")]
public CName OPEN_BESTIARY { get; set;}

#endregion
}
}