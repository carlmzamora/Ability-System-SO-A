using UnityEngine;

namespace ScriptableObjectArchitecture
{
	[AddComponentMenu(SOArchitecture_Utility.EVENT_LISTENER_SUBMENU + "Parameters")]
	public sealed class ParametersGameEventListener : BaseGameEventListener<Parameters, ParametersGameEvent, ParametersUnityEvent>
	{
	}
}