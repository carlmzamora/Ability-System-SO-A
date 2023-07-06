using UnityEngine;
using UnityEngine.Events;

namespace ScriptableObjectArchitecture
{
	[System.Serializable]
	public class TransformEvent : UnityEvent<Transform> { }

	[CreateAssetMenu(
	    fileName = "TransformVariable.asset",
	    menuName = SOArchitecture_Utility.VARIABLE_SUBMENU + "Transform",
	    order = 120)]
	public class TransformVariable : BaseVariable<Transform, TransformEvent>
	{
	}
}