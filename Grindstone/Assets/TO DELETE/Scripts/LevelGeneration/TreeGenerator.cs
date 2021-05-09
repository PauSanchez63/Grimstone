using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeGenerator : MonoBehaviour
{
    public GameObject[] treeTiles;
    public GameObject[] leftTreeDecorations;
    public GameObject[] rightTreeDecorations;
    public GameObject[] cabins;

    public float moveAmount;
    public float startTimeBtwTiles;
    private float timeBtwTiles;
    public int steps;
    public int tilesNum;

    public int probability;
    public bool spawnHouse;

    // Start is called before the first frame update
    void Start()
    {
        timeBtwTiles = startTimeBtwTiles;
        Instantiate(treeTiles[Random.Range(0, treeTiles.Length)], this.transform.position, this.transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        if (steps < tilesNum)
        {
            if (timeBtwTiles <= 0)
            {
                Move();
                timeBtwTiles = startTimeBtwTiles;
            }
            else
            {
                timeBtwTiles -= Time.deltaTime;
            }
        }
    }

    void Move()
    {
        this.transform.Translate(new Vector3(0, moveAmount, 0));
        Instantiate(treeTiles[Random.Range(0, treeTiles.Length)], this.transform.position, this.transform.rotation);
        steps++;
        int rand = Random.Range(0, 100 / probability);
        if (rand == 7) //Decoration at right
        {
            Instantiate(rightTreeDecorations[Random.Range(0, rightTreeDecorations.Length)], this.transform.position + new Vector3(moveAmount, 0, 0), this.transform.rotation);
        }
        else if (rand == 5) //Decoration at left
        {
            Instantiate(leftTreeDecorations[Random.Range(0, leftTreeDecorations.Length)], this.transform.position - new Vector3(moveAmount, 0, 0), this.transform.rotation);
        }
        else if (rand == 13) //Decoration at both sides
        {
            Instantiate(leftTreeDecorations[Random.Range(0, leftTreeDecorations.Length)], this.transform.position - new Vector3(moveAmount, 0, 0), this.transform.rotation);
            Instantiate(rightTreeDecorations[Random.Range(0, rightTreeDecorations.Length)], this.transform.position + new Vector3(moveAmount, 0, 0), this.transform.rotation);
        }
        else if (rand == 1 && spawnHouse)
        {
            GameObject cabin = Instantiate(cabins[Random.Range(0, cabins.Length)], this.transform.position, this.transform.rotation);
            cabin.GetComponent<SpriteRenderer>().sortingOrder = 3;
        }
    }
}
