using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    #region variables

    public int life;

    public float speed;
    public float jumpForce;
    public float dodgeForce;

    private Animator myAnim;
    private Rigidbody2D myRigid;
    private BoxCollider2D myCollid;

    private float jumpTime = 1;
    private float currentJumpTime;

    private float dodgeTime = 1.6f;
    private float currentDodgeTime;

    public float attackCharge;
    private bool startedCharge;

    #endregion

    // Start is called before the first frame update
    void Start()
    {
        myAnim = transform.GetChild(0).GetComponent<Animator>();
        myRigid = GetComponent<Rigidbody2D>();
        myCollid = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (!startedCharge)
        {
            Move();
            Jump();
            Dodge();
        }
        Attack();
    }

    #region PublicMethods

    public void Damage(int damage, bool execution)
    {
        life -= damage;
        if (life <= 0)
        {
            if (!execution)
            {
                myAnim.SetTrigger("Death");                
            }
            life = 0;
            enabled = false;
        }
        else
        {
            myAnim.SetTrigger("Damage");
            myRigid.AddForce(transform.right * -dodgeForce);
        }
    }

    #endregion

    #region Methods

    void Move()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(new Vector3(speed * Time.deltaTime, 0, 0));
            transform.localRotation = Quaternion.Euler(new Vector3(0, 180, 0));
            myAnim.SetBool("Move", true);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(new Vector3(speed * Time.deltaTime, 0, 0));
            myAnim.SetBool("Move", true);
            transform.localRotation = Quaternion.Euler(new Vector3(0, 0, 0));
        }
        if(!Input.GetKey(KeyCode.A) && !Input.GetKey(KeyCode.D))
        {
            myAnim.SetBool("Move", false);
        }
    }

    void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space) && currentJumpTime <= 0)
        {
            currentJumpTime = jumpTime;
            myAnim.SetTrigger("Jump");
            myRigid.AddForce(new Vector3(0, jumpForce, 0));
        }
        else
        {
            currentJumpTime -= Time.deltaTime;
        }
    }

    void Dodge()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift) && currentDodgeTime <= 0)
        {
            StartCoroutine(DodgeCor());
            currentDodgeTime = dodgeTime;
            myAnim.SetTrigger("Dodge");
        }
        else
        {
            currentDodgeTime -= Time.deltaTime;
        }
    }
 
    void Attack()
    {
        if (Input.GetMouseButton(0))
        {
            if (!startedCharge)
            {
                startedCharge = true;
                myAnim.SetTrigger("LoadAttack");
            }
            attackCharge += Time.deltaTime;
        }
        if(Input.GetMouseButtonUp(0))
        {
            if (attackCharge >= 0.85f)
            {
                myAnim.SetTrigger("Attack");
                attackCharge = 0;
                StartCoroutine(AttackCor());
            }
            else
            {
                myAnim.SetTrigger("NotAttack");
                attackCharge = 0;
                StartCoroutine(DischargeCor());
            }
        }
    }

    #endregion

    #region Coroutines

    IEnumerator DodgeCor()
    {
        yield return new WaitForSeconds(0.5f);
        myRigid.AddForce(transform.right * -dodgeForce);
    }

    IEnumerator AttackCor()
    {
        yield return new WaitForSeconds(1f);
        startedCharge = false;
    }

    IEnumerator DischargeCor()
    {
        if (attackCharge >= 0.5f)
        {
            yield return new WaitForSeconds(0.5f);
        }
        else
        {
            yield return new WaitForSeconds(1f);
        }
        startedCharge = false;
    }

    #endregion

    private void OnCollision2DEnter(Collider2D other)
    {
        Debug.Log(other.name);
    }
}
