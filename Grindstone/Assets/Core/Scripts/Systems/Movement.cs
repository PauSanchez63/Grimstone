using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Systems
{
    public class Movement : MonoBehaviour
    {
        #region Variables
        [NonSerialized] public static Movement Instance;

        [SerializeField] private Rigidbody2D playerRigidbody;
        [SerializeField] private float movSpeed;
        [SerializeField] private float movAcceleration;
        [SerializeField] private float jumpForce;

        private Vector2 m;
        private bool jumping = false;
        private bool canMove = true;

        [SerializeField] private float jumpRayDistance;
        [SerializeField] private float fallRayDistance;
        [SerializeField] private float ledgeRayDistance;
        [SerializeField] private GameObject rightFoot;
        [SerializeField] private GameObject leftFoot;

        [NonSerialized] public UnityEvent onLedgeGrabed = new UnityEvent();
        [NonSerialized] public UnityEvent onLand = new UnityEvent();
        #endregion

        private void Awake()
        {
            if(Instance == null)
            {
                Instance = this;
            }
            else
            {
                Destroy(this);
            }
        }

        private void Start()
        {
            InputManager.Instance.onMove.AddListener(Move);
            InputManager.Instance.onMoveLeft.AddListener(MoveLeft);
            InputManager.Instance.onMoveRight.AddListener(MoveRight);
            InputManager.Instance.onStopMove.AddListener(StopMove);
            InputManager.Instance.onJump.AddListener(Jump);
            onLedgeGrabed.AddListener(GrabLedge);
        }

        private void FixedUpdate()
        {
            if (canMove)
            {
                transform.Translate(m, Space.World);
            }
        }

        #region Methods
        private void Move()
        {
            m = new Vector2(InputManager.Instance.movementAmount.x, 0) * Time.deltaTime * movSpeed;
        }

        private void MoveLeft()
        {

            m = new Vector2(-1, 0) * Time.deltaTime * movSpeed;
        }

        private void MoveRight()
        {
            m = new Vector2(1, 0) * Time.deltaTime * movSpeed;
        }

        private void StopMove()
        {
            m = new Vector2(0, 0);
        }

        private void Jump()
        {
            if (IsPlayerGrounded(false)) 
            {
                jumping = true;
                playerRigidbody.AddForce(Vector3.up * jumpForce);
                StartCoroutine(AfterJumpChecker());
            }
        }

        private void GrabLedge()
        {
            playerRigidbody.isKinematic = true;
            playerRigidbody.velocity = Vector2.zero;
            canMove = false;
        }
        #endregion

        #region Coroutines
        IEnumerator AfterJumpChecker()
        {
            bool takeOff = false;
            while (!takeOff)
            {
                if (!IsPlayerGrounded(false))
                {
                    takeOff = true;
                }
                yield return null;
            }
            while (jumping)
            {
                if (takeOff)
                {
                    if (IsPlayerGrounded(true))
                    {
                        jumping = false;
                        onLand?.Invoke();
                    }
                    else if (CanPlayerGrabOnLedge())
                    {
                        jumping = false;
                        onLedgeGrabed?.Invoke();
                    }
                }
                yield return null;
            }
        }
        #endregion

        #region Utils
        private bool IsPlayerGrounded(bool falling)
        {
            float rayDistance;
            if (falling) { rayDistance = fallRayDistance; }
            else { rayDistance = jumpRayDistance; }

            LayerMask mask = LayerMask.GetMask("Platforms");

            RaycastHit2D hit = Physics2D.Raycast(this.transform.position, -this.transform.up, rayDistance, mask);
            Debug.DrawRay(this.transform.position, -this.transform.up * rayDistance, Color.magenta, 0.5f);
            if (hit.collider != null)
            {
                return true;
            }
            RaycastHit2D rHit = Physics2D.Raycast(rightFoot.transform.position, -this.transform.up, rayDistance, mask);
            Debug.DrawRay(rightFoot.transform.position, -this.transform.up * rayDistance, Color.magenta, 0.5f);
            if (rHit.collider != null)
            {
                return true;
            }
            RaycastHit2D lHit = Physics2D.Raycast(leftFoot.transform.position, -this.transform.up, rayDistance, mask);
            Debug.DrawRay(leftFoot.transform.position, -this.transform.up * rayDistance, Color.magenta, 0.5f);
            if (lHit.collider != null)
            {
                return true;
            }
            return false;
        }

        private bool CanPlayerGrabOnLedge()
        {
            LayerMask mask = LayerMask.GetMask("Walls");

            RaycastHit2D rHit = Physics2D.Raycast(this.transform.position, this.transform.right, ledgeRayDistance, mask);
            Debug.DrawRay(this.transform.position, this.transform.right * ledgeRayDistance, Color.green, 0.5f);
            if (rHit.collider != null)
            {
                if (rHit.collider.name == "Corner")
                {
                    return true;
                }
            }
            RaycastHit2D lHit = Physics2D.Raycast(this.transform.position, -this.transform.right, ledgeRayDistance, mask);
            Debug.DrawRay(this.transform.position, -this.transform.right * ledgeRayDistance, Color.green, 0.5f);
            if (lHit.collider != null)
            {
                if (lHit.collider.name == "Corner")
                {
                    return true;
                }
            }
            return false;
        }
        #endregion
    }
}
