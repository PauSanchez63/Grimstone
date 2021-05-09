using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlimeScript : MonoBehaviour
{
    public GameObject player;

    public float speed;
    public float range;
    public int damage;

    private Vector3 distance;
    public float distlenght;

    private Animator myAnim;
    private Rigidbody2D myRigid;

    private float movTime = 3.5f;
    private float currentTime;
    public bool execute;
    private int rand;

    private float startAnim;
    private float collided;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        myAnim = GetComponent<Animator>();
        myRigid = GetComponent<Rigidbody2D>();
        rand = Random.Range(0, 2);
        if (rand == 1)
        {
            execute = true;
        }
        else
        {
            execute = false;
        }

    }

    // Update is called once per frame
    void Update()
    {
        distlenght = distance.magnitude;
        //Cambiar por OnDrawGizmos
        distance = player.transform.position - this.transform.position;
        if(distance.magnitude <= range)
        {
            int irvLife = player.GetComponent<PlayerMovement>().life;
            if(irvLife >= damage)
            {
                myAnim.SetTrigger("OnRange");
                startAnim = Time.time;
            }
        }
        else
        {
            currentTime -= Time.deltaTime;
            if(currentTime <= 0)
            {                
                StartCoroutine(MoveCor());
                myAnim.SetTrigger("Move");
                currentTime = 1000;
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.transform.tag == "Player")
        {
            if (player.GetComponent<PlayerMovement>().life == damage && execute)
            {
                myAnim.SetTrigger("IrvingCanDie");
                collided = Time.time;
                StartCoroutine(DeadIrvin());
                player.SetActive(false);
            }
            player.GetComponent<PlayerMovement>().Damage(damage, execute);
        }
    }

    IEnumerator DeadIrvin()
    {
        yield return new WaitForSeconds(collided-startAnim);
        player.SetActive(false);
    }

    IEnumerator MoveCor()
    {
        yield return new WaitForSeconds(0.59f);
        Debug.Log("AddForce");
        myRigid.AddForce(new Vector2(-speed, 0));
        yield return new WaitForSeconds(1.81f);
        currentTime = movTime;
    }
}
