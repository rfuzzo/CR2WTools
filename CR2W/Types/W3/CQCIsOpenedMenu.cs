using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CQCIsOpenedMenu : IUIConditionType
{
#region RED Properties

[REDProp("menuToBeOpened")]
public CName MenuToBeOpened { get; set;}

#endregion
}
}