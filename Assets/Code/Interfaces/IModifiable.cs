using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IModifiable
{
    List<Modifier> Modifiers { get; }
    List<ModifierData> StoredModifiers { get; }
}
