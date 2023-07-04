using UnityEngine;

namespace ScriptableObjectArchitecture
{
	[System.Serializable]
	public sealed class ParametersReference : BaseReference<Parameters, ParametersVariable>
	{
	    public ParametersReference() : base() { }
	    public ParametersReference(Parameters value) : base(value) { }
	}
}