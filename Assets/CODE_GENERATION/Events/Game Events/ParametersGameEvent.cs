using UnityEngine;

namespace ScriptableObjectArchitecture
{
	[System.Serializable]
	[CreateAssetMenu(
	    fileName = "ParametersGameEvent.asset",
	    menuName = SOArchitecture_Utility.GAME_EVENT + "Parameters",
	    order = 120)]
	public sealed class ParametersGameEvent : GameEventBase<Parameters>
	{
	}
}