using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3MessagePopupData : CObject
{
#region RED Properties

[REDProp("actionsList")]
public Array<UserMessageActionData> ActionsList { get; set;}

[REDProp("titleText")]
public string TitleText { get; set;}

[REDProp("messageText")]
public string MessageText { get; set;}

[REDProp("messageId")]
public Int32 MessageId { get; set;}

[REDProp("autoLocalize")]
public bool AutoLocalize { get; set;}

[REDProp("messageType")]
public EUserDialogButtons MessageType { get; set;}

[REDProp("priority")]
public Int32 Priority { get; set;}

[REDProp("progress")]
public float Progress { get; set;}

[REDProp("progressType")]
public EUserMessageProgressType ProgressType { get; set;}

[REDProp("progressTag")]
public CName ProgressTag { get; set;}

#endregion
}
}