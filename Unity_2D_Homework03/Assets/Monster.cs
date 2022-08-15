
using UnityEngine;

namespace LP
{
    public class Monster : MonoBehaviour
    {
        #region Monster
        [Range(0,10),Header("���ʳt��")]
        public float Speed = 3.5f;
        [Range(0,500)]
        public int Attack = 100;
        [Range(0,5000)]
        public int HP = 350;
        [Range(0,50)]
        public int TrackRange = 30;
        public Vector3 TrackMove;
        [Header("�����D��")]
        public bool GameObject = false;
        [Range(0,1)]
        public float ChanceOfGameObject = 1f;
        [Header("����")]
        public AudioClip DropSound;
        public AudioClip HurtSound;
        public AudioClip AttackSound;
        private AudioSource AudioSource;
        private Rigidbody2D Rigidbody2D;
        private Animator Animator;
        #endregion

    }
}

