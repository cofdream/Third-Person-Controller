﻿using UnityEngine;
using System.Collections;

namespace SA
{
    [CreateAssetMenu(menuName = "Variable/State Manager")]
    public class StateManagerVariable : ScriptableObject
    {
        public StateManager value;

        public void Set(StateManager stateManager)
        {
            value = stateManager;
        }

    }
}