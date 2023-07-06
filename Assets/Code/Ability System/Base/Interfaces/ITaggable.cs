using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace carlmzamora.AbilitySystem
{
    public interface ITaggable
    {
        List<Tag> Tags { get; }
    }
}