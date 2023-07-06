using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace carlmzamora.AbilitySystem
{
    public class AbilityHolder : MonoBehaviour
    {
        private enum AbilityState
        {
            READY,
            ACTIVE,
            ON_COOLDOWN
        }

        [SerializeField] private Ability ability;
        [SerializeField] private bool useMouseButton = false;
        [SerializeField] private KeyCode keyToPress;
        [SerializeField] private int mouseButtonInt;

        private AbilityState state = AbilityState.READY;
        private float currentActiveTime;
        private float currentCooldownTime;

        private void Update()
        {

            switch (state)
            {
                case AbilityState.READY:
                    if (!useMouseButton)
                    {
                        if (Input.GetKeyDown(keyToPress))
                        {
                            ability.Activate();
                            state = AbilityState.ACTIVE;
                            currentActiveTime = ability.Duration;
                        }
                    }
                    else
                    {
                        if (Input.GetMouseButtonDown(mouseButtonInt))
                        {
                            ability.Activate();
                            state = AbilityState.ACTIVE;
                            currentActiveTime = ability.Duration;
                        }
                    }
                    break;

                case AbilityState.ACTIVE:
                    if (currentActiveTime > 0)
                    {
                        currentActiveTime -= Time.deltaTime;
                    }
                    else
                    {
                        state = AbilityState.ON_COOLDOWN;
                        currentCooldownTime = ability.Cooldown;
                    }
                    break;

                case AbilityState.ON_COOLDOWN:
                    if (currentCooldownTime > 0)
                    {
                        currentCooldownTime -= Time.deltaTime;
                    }
                    else
                    {
                        state = AbilityState.READY;
                    }
                    break;
            }
        }
    }
}