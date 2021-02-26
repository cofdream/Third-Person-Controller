using SO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SA
{
    [CreateAssetMenu(menuName = "Actions/Mono Actions/Rotation via Input")]
    public class RotateViaInput : Action
    {
        public FloatVariable targetFloat;
        public TransformVariable targetVariable;

        public float angle;
        public float speed = 9f;
        public bool negative;
        public bool clamp;
        public float minClamp = -35f;
        public float maxClamp = 35f;
        public RotateAxis targetAxis;

        public override void Execute()
        {
            if (!negative)
                angle += targetFloat.value * speed;
            else
                angle -= targetFloat.value * speed;

            if (clamp)
            {
                angle = Mathf.Clamp(angle, minClamp, maxClamp);
            }

            switch (targetAxis)
            {
                case RotateAxis.x:
                    targetVariable.value.rotation = Quaternion.Euler(angle, 0, 0);
                    break;
                case RotateAxis.y:
                    targetVariable.value.rotation = Quaternion.Euler(0, angle, 0);
                    break;
                case RotateAxis.z:
                    targetVariable.value.rotation = Quaternion.Euler(0, 0, angle);
                    break;
            }
        }
        public enum RotateAxis
        {
            x, y, z
        }
    }

}