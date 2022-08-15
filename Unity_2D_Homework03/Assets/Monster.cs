
using UnityEngine;

namespace LP
{
    public class Monster : MonoBehaviour
    {
        #region Monster
        [Range(0,10),Header("移動速度")]
        public float Speed = 3.5f;
        [Range(0,500)]
        public int Attack = 100;
        [Range(0,5000)]
        public int HP = 350;
        [Range(0,50)]
        public int TrackRange = 30;
        public Vector3 TrackMove;
        [Header("掉落道具")]
        public bool GameObject = false;
        [Range(0,1)]
        public float ChanceOfGameObject = 1f;
        [Header("音效")]
        public AudioClip DropSound;
        public AudioClip HurtSound;
        public AudioClip AttackSound;
        private AudioSource AudioSource;
        private Rigidbody2D Rigidbody2D;
        private Animator Animator;
        #endregion

    }
}

