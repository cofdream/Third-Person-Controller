﻿using System.Collections;
using UnityEngine;

namespace SA
{
    [CreateAssetMenu(menuName = "Actions/State Actions/Collider Status")]
    public class ColliderStatus : StateActions
    {
        public bool status;
        public override void Execute(StateManager states)
        {
            states.collider.enabled = status;
        }
    }
}