using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3DestroyableTerrain : CInteractiveEntity
{
#region RED Properties

[REDProp("m_destroyableElements")]
public Array<Array<Handle<CScriptedDestroyableComponent>>> M_destroyableElements { get; set;}

[REDProp("m_piecesIdToSplit")]
public Array<Int32> M_piecesIdToSplit { get; set;}

[REDProp("m_player")]
public Handle<CPlayer> M_player { get; set;}

[REDProp("m_activated")]
public bool M_activated { get; set;}

[REDProp("m_componentName")]
public string M_componentName { get; set;}

[REDProp("m_randNumber")]
public Int32 M_randNumber { get; set;}

[REDProp("tickTime")]
public float TickTime { get; set;}

[REDProp("tickInterval")]
public float TickInterval { get; set;}

[REDProp("currRandNumbId")]
public Int32 CurrRandNumbId { get; set;}

[REDProp("currRandNumbTime")]
public float CurrRandNumbTime { get; set;}

[REDProp("m_numOfPiecesToDestroy")]
public Int32 M_numOfPiecesToDestroy { get; set;}

[REDProp("m_timeBetweenRandomDestroyMin")]
public Int32 M_timeBetweenRandomDestroyMin { get; set;}

[REDProp("m_timeBetweenRandomDestroyMax")]
public Int32 M_timeBetweenRandomDestroyMax { get; set;}

#endregion
}
}