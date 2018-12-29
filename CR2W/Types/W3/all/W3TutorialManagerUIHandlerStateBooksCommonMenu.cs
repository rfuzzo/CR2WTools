using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3TutorialManagerUIHandlerStateBooksCommonMenu : W3TutorialManagerUIHandlerStateTutHandlerBaseState
{
#region RED Properties

[REDProp("OPEN_COMMON_MENU")]
public CName OPEN_COMMON_MENU { get; set;}

[REDProp("SELECT_GLOSSARY")]
public CName SELECT_GLOSSARY { get; set;}

#endregion
}
}