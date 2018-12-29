using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3TutorialManagerUIHandlerStateBooksNew : W3TutorialManagerUIHandlerStateTutHandlerBaseState
{
#region RED Properties

[REDProp("BOOKS_PANEL")]
public CName BOOKS_PANEL { get; set;}

[REDProp("NAVIGATION")]
public CName NAVIGATION { get; set;}

[REDProp("OPEN_GLOSSARY")]
public CName OPEN_GLOSSARY { get; set;}

[REDProp("isClosing")]
public bool IsClosing { get; set;}

#endregion
}
}