using UnityEngine;
using UnityEngine.Events;

namespace ScriptableObjectArchitecture
{
	[System.Serializable]
	public class ParametersEvent : UnityEvent<Parameters> { }

	[CreateAssetMenu(
	    fileName = "ParametersVariable.asset",
	    menuName = SOArchitecture_Utility.VARIABLE_SUBMENU + "Parameters",
	    order = 120)]
	public class ParametersVariable : BaseVariable<Parameters, ParametersEvent>
	{
	}
}