using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovementIS : MonoBehaviour
{
    ////PlayerControlls controlls;
    //public MovementAndAttackIrvin mAAI;

    //Vector2 move;
    //private InputController controlls;

    //private void Awake()
    //{
    //    controlls = new InputController();

    //    controlls.Gameplay.Jump.performed += ctx => mAAI.Jump();
    //    controlls.Gameplay.Move.performed += ctx => move = ctx.ReadValue<Vector2>();
    //    controlls.Gameplay.Move.canceled += ctx => move = Vector2.zero;
    //}

    //private void OnEnable()
    //{
    //    controlls.Gameplay.Enable();
    //}

    //private void OnDisable()
    //{
    //    controlls.Gameplay.Disable();
    //}

    //private void Update()
    //{
    //    Vector2 m = new Vector2(move.x, 0) * Time.deltaTime * mAAI.movSpeed;
    //    transform.Translate(m, Space.World);
    //}

}
