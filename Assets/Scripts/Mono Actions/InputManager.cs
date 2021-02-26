using SO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SA
{
    [CreateAssetMenu(menuName = "Actions/Mono Actions/Input Manager")]
    public class InputManager : Action
    {
        public FloatVariable horizontal;
        public FloatVariable vertical;

        public StateManagerVariable playerStates;
        public ActionBatch inputUpdateBatch;
        public override void Execute()
        {
            inputUpdateBatch.Execute();

            if (playerStates != null)
            {
                playerStates.value.movementVariables.horizontal = horizontal.value;
                playerStates.value.movementVariables.vertical = vertical.value;

                playerStates.value.movementVariables.moveAmount = Mathf.Clamp01(Mathf.Abs(horizontal.value) + Mathf.Abs(vertical.value));
            }
        }
    }
}
