using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CR4CharacterMenu : CR4MenuBase
{
#region RED Properties

[REDProp("initDataBuySkill")]
public Handle<W3BuySkillConfirmation> InitDataBuySkill { get; set;}

[REDProp("_playerInv")]
public Handle<W3GuiPlayerInventoryComponent> _playerInv { get; set;}

[REDProp("_inv")]
public Handle<CInventoryComponent> _inv { get; set;}

[REDProp("_charStatsPopupData")]
public Handle<CharacterStatsPopupData> _charStatsPopupData { get; set;}

[REDProp("_sentStats")]
public Array<SentStatsData> _sentStats { get; set;}

[REDProp("currentlySelectedTab")]
public Int32 CurrentlySelectedTab { get; set;}

[REDProp("m_previousSkillBonuses")]
public Array<string> M_previousSkillBonuses { get; set;}

[REDProp("m_fxPaperdollChanged")]
public Handle<CScriptedFlashFunction> M_fxPaperdollChanged { get; set;}

[REDProp("m_fxClearSkillSlot")]
public Handle<CScriptedFlashFunction> M_fxClearSkillSlot { get; set;}

[REDProp("m_fxNotifySkillUpgraded")]
public Handle<CScriptedFlashFunction> M_fxNotifySkillUpgraded { get; set;}

[REDProp("m_fxActivateRunwordBuf")]
public Handle<CScriptedFlashFunction> M_fxActivateRunwordBuf { get; set;}

[REDProp("m_fxSetMutationBonusMode")]
public Handle<CScriptedFlashFunction> M_fxSetMutationBonusMode { get; set;}

[REDProp("m_fxConfirmMutResearch")]
public Handle<CScriptedFlashFunction> M_fxConfirmMutResearch { get; set;}

[REDProp("m_fxResetInput")]
public Handle<CScriptedFlashFunction> M_fxResetInput { get; set;}

[REDProp("m_mutationBonusMode")]
public bool M_mutationBonusMode { get; set;}

[REDProp("MAX_BONUS_SOCKETS")]
public Int32 MAX_BONUS_SOCKETS { get; set;}

[REDProp("MAX_MASTER_MUTATION_STAGE")]
public Int32 MAX_MASTER_MUTATION_STAGE { get; set;}

#endregion
}
}