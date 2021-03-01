using UnityEngine;
using System.Collections;

namespace SA
{
    [CreateAssetMenu(menuName = "Conditions/HasLanded")]
    public class HasLanded : Condition
    {
        public override bool CheckCondition(StateManager state)
        {
            if (Time.realtimeSinceStartup - state.timeSinceJump > 1f)
            {
                return state.isGrounded;
            }
            else
            {
                return false;
            }
        }
    }
}