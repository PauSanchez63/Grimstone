using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Systems
{
    public class Animation : MonoBehaviour
    {
        #region Variables
        [SerializeField] private Animator anim;
        [SerializeField] private Transform playerTransform;

        private bool endCombo = true;
        private bool hasPunched = false;
        #endregion

        void Start()
        {
            InputManager.Instance.onMove.AddListener(Move);
            InputManager.Instance.onMoveLeft.AddListener(MoveLeft);
            InputManager.Instance.onMoveRight.AddListener(MoveRight);
            InputManager.Instance.onStopMove.AddListener(StopMove);

            InputManager.Instance.onJump.AddListener(Jump);
            Movement.Instance.onLand.AddListener(Land);
            
            InputManager.Instance.onAttack.AddListener(Attack);

            //Movement.Instance.onLedgeGrabed.AddListener(LedgeGrab);
        }

        #region Methods
        private void Move()
        {
            AlignPlayerSpriteWithMovementDirection();
            if (!anim.GetBool("Move"))
            {
                anim.SetBool("Move", true);
            }
        }
        private void MoveLeft()
        {
            AlignPlayerToLeft();
            if (!anim.GetBool("Move"))
            {
                anim.SetBool("Move", true);
            }
        }
        private void MoveRight()
        {
            AlignPlayerToRight();
            if (!anim.GetBool("Move"))
            {
                anim.SetBool("Move", true);
            }
        }

        private void StopMove()
        {
            anim.SetBool("Move", false);
        }

        private void Jump()
        {
            anim.SetTrigger("Jump");
            anim.SetBool("Falling", true);
        }
        private void Land()
        {
            anim.SetBool("Falling", false);
        }

        private void Attack()
        {
            anim.SetTrigger("Punch");
            if (hasPunched)
            {
                endCombo = false;
            }
            else
            {
                hasPunched = true;
            }
        }
        #endregion

        #region Coroutines
        #endregion

        #region Utils
        private void AlignPlayerSpriteWithMovementDirection()
        {
            if (InputManager.Instance.movementAmount.x >= 0)
            {
                AlignPlayerToRight();   
            }
            else
            {
                AlignPlayerToLeft();
            }
        }

        private void AlignPlayerToLeft()
        {
            if (playerTransform.rotation.eulerAngles.y < 90)
            {
                playerTransform.rotation = Quaternion.Euler(0, 180, 0);
            }
        }

        private void AlignPlayerToRight()
        {
            if (playerTransform.rotation.eulerAngles.y > 90)
            {
                playerTransform.rotation = Quaternion.Euler(0, 0, 0);
            }
        }

        private void EndCombo()
        {
            if (endCombo)
            {
                anim.SetTrigger("End Combo");
                hasPunched = false;
            }
            endCombo = true;
        }
        #endregion
    }
}
