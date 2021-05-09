using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class InputManager : MonoBehaviour
{
    [NonSerialized] public static InputManager Instance;

    [NonSerialized] public UnityEvent onJump = new UnityEvent();
    [NonSerialized] public UnityEvent onMove = new UnityEvent();
    [NonSerialized] public UnityEvent onStopMove = new UnityEvent();
    [NonSerialized] public UnityEvent onMoveLeft = new UnityEvent();
    [NonSerialized] public UnityEvent onMoveRight = new UnityEvent();
    [NonSerialized] public UnityEvent onAttack = new UnityEvent();
    [NonSerialized] public UnityEvent onPause = new UnityEvent();

    [NonSerialized] public InputController inputController;

    [NonSerialized] public Vector2 movementAmount = new Vector2(0,0);

    private bool moveLeftIsHeldDown = false;
    private bool moveRightIsHeldDown = false;

    // Start is called before the first frame update
    void Awake()
    {
        if(Instance == null)
        {
            DontDestroyOnLoad(gameObject);
            Instance = this;
        }
        else
        {
            Destroy(this);
        }

        inputController = new InputController();

        SetMethodsToInputs();
    }

    private void SetMethodsToInputs()
    {
        inputController.Gameplaykeyboard.Jump.performed += ctx => Jump();
        inputController.Gameplaycontroller.Jump.performed += ctx => Jump();

        inputController.Gameplaykeyboard.MoveLeft.performed += ctx => MoveLeft();
        inputController.Gameplaykeyboard.MoveRight.performed += ctx => MoveRight();
        inputController.Gameplaycontroller.Move.performed += ctx => Move(ctx.ReadValue<Vector2>());
        inputController.Gameplaycontroller.Move.canceled += ctx => StopMove();
        inputController.Gameplaykeyboard.MoveRight.canceled += ctx => StopMoveFromRight();
        inputController.Gameplaykeyboard.MoveLeft.canceled += ctx => StopMoveFromLeft();

        inputController.Gameplaykeyboard.Attack.performed += ctx => Attack();
        inputController.Gameplaycontroller.Attack.performed += ctx => Attack();

        inputController.Gameplaykeyboard.Pause.performed += ctx => Pause();
        inputController.Gameplaycontroller.Pause.performed += ctx => Pause();
    }

    #region Invoke Input Events
    private void Jump() { onJump?.Invoke(); }
    private void Move(Vector2 joystickValues) { movementAmount = joystickValues; onMove?.Invoke(); }
    private void MoveLeft() { moveLeftIsHeldDown = true; onMoveLeft?.Invoke(); }
    private void MoveRight() { moveRightIsHeldDown = true; onMoveRight?.Invoke(); }

    private void StopMoveFromRight()
    {
        moveRightIsHeldDown = false;
        if (!moveLeftIsHeldDown) { StopMove(); }
        else { MoveLeft(); }
    }

    private void StopMoveFromLeft()
    {
        moveLeftIsHeldDown = false;
        if (!moveRightIsHeldDown) { StopMove(); }
        else { MoveRight(); }
    }

    private void StopMove() { onStopMove?.Invoke(); }

    private void Attack() { onAttack?.Invoke(); }

    private void Pause() { onPause.Invoke(); }
    #endregion

    #region OnEnable & OnDisable
    //Keyboard will enable by default
    private void OnEnable()
    {
        inputController.Gameplaykeyboard.Enable();
    }

    private void OnDisable()
    {
        inputController.Gameplaykeyboard.Disable();
    }
    #endregion
}
