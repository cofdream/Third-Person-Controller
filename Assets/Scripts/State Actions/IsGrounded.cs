using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SA
{
    [CreateAssetMenu(menuName = "Actions/State Actions/Is Grounded")]
    public class IsGrounded : StateActions
    {
        public override void Execute(StateManager states)
        {
            Vector3 origin = states.mTransform.position;
            origin.y += 0.7f;

            Vector3 direction = -Vector3.up;
            float distance = 1.4f;

            if (Physics.Raycast(origin, direction, out RaycastHit hit, distance))
            {
                states.isGround = true;
            }
            else
            {
                states.isGround = false;
            }
        }
    }

}