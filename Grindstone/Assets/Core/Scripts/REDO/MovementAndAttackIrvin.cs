using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MovementAndAttackIrvin : MonoBehaviour
{
    ////Events
    //[NonSerialized] public UnityEvent onMoveRight = new UnityEvent();
    //[NonSerialized] public UnityEvent onMoveLeft = new UnityEvent();
    //[NonSerialized] public UnityEvent onJump = new UnityEvent();
    //[NonSerialized] public UnityEvent onAttack = new UnityEvent();
    
    //private Rigidbody2D rb;

    //[Header("Movement")]
    //[SerializeField] public float movSpeed;
    //[SerializeField] private float jumpForce;
    //[SerializeField] private float rayDistance;
    //[SerializeField] private GameObject leftFoot;
    //[SerializeField] private GameObject rightFoot;

    //[Header("Attack")]
    //[SerializeField] private float attackSpeed;

    //// Start is called before the first frame update
    //void Start()
    //{
    //    onMoveRight.AddListener(MoveRight);
    //    onMoveLeft.AddListener(MoveLeft);
    //    onJump.AddListener(Jump);
    //    onAttack.AddListener(Attack);
    //    rb = GetComponent<Rigidbody2D>();
    //}

    //// Update is called once per frame
    //void Update()
    //{
    //    if (Input.GetKey(InputChanger.Instance.right))
    //    {
    //        onMoveRight?.Invoke();
    //    }
    //    if (Input.GetKey(InputChanger.Instance.left))
    //    {
    //        onMoveLeft?.Invoke();
    //    }
    //    if (Input.GetKeyDown(InputChanger.Instance.jump) && IsPlayerGrounded())
    //    {
    //        onJump?.Invoke();
    //    }
    //    if (Input.GetKeyDown(InputChanger.Instance.attack))
    //    {
    //        onAttack?.Invoke();
    //    }
    //}

    //#region Methods
    //public void MoveRight()
    //{
    //    this.transform.Translate(Vector3.right * movSpeed * Time.deltaTime);
    //}

    //public void MoveLeft()
    //{
    //    this.transform.Translate(-Vector3.right * movSpeed * Time.deltaTime);
    //}

    //public void Jump()
    //{        
    //    rb.AddForce(Vector3.up * jumpForce);
    //}

    //public void Attack()
    //{       
    //    Debug.Log("Attack");
    //}
    //#endregion

    //#region Utils
    //private bool IsPlayerGrounded()
    //{ 
    //    RaycastHit2D hit = Physics2D.Raycast(this.transform.position, -this.transform.up, rayDistance, 9);
    //    Debug.DrawRay(this.transform.position, -this.transform.up * rayDistance, Color.magenta, 0.5f);
    //    if(hit.collider != null)
    //    {
    //        return true;
    //    }
    //    RaycastHit2D rHit = Physics2D.Raycast(rightFoot.transform.position, -this.transform.up, rayDistance, 9);
    //    Debug.DrawRay(rightFoot.transform.position, -this.transform.up * rayDistance, Color.magenta, 0.5f);
    //    if (rHit.collider != null)
    //    {
    //        return true;
    //    }
    //    RaycastHit2D lHit = Physics2D.Raycast(leftFoot.transform.position, -this.transform.up, rayDistance, 9);
    //    Debug.DrawRay(leftFoot.transform.position, -this.transform.up * rayDistance, Color.magenta, 0.5f);
    //    if (lHit.collider != null)
    //    {
    //        return true;
    //    }
    //    return false;
    //}
    //#endregion
}
