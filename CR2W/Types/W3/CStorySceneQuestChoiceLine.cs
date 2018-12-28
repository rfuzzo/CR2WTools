using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CStorySceneQuestChoiceLine : CStorySceneComment
{
#region RED Properties

[REDProp("elementID")]
public string ElementID { get; set;}

[REDProp("approvedDuration")]
public float ApprovedDuration { get; set;}

[REDProp("isCopy")]
public bool IsCopy { get; set;}

[REDProp("commentText")]
public LocalizedString CommentText { get; set;}

[REDProp("emphasisLine")]
public bool EmphasisLine { get; set;}

[REDProp("returnToChoice")]
public bool ReturnToChoice { get; set;}

[REDProp("action")]
public Ptr<IStorySceneChoiceLineAction> Action { get; set;}

#endregion
}
}