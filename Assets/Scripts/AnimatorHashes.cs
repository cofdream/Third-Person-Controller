using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SA
{
    public class AnimatorHashes 
    {
        public int vertical = Animator.StringToHash("vertical");
        public int horizontal = Animator.StringToHash("horizontal");
        public int leftFootForward = Animator.StringToHash("leftFootForward");
        public int jumpForward = Animator.StringToHash("Jump Forward");
        public int jumpIdle = Animator.StringToHash("Jump Idle");
    }

}