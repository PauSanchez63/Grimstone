using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class LevelTileGenerator : MonoBehaviour
{
    #region variables

    public GameObject player;
    public GameObject treeGenerator;

    public Tile[] mudTiles;
    public int mudAmount;

    private float moveAmount = 1;
    private int direction;

    public int tilesNumber;
    private int tilesCounter = 0;

    public int villageLarger;
    private int villageCounter = 0;

    public Tilemap tilemap;
    public Tilemap mudTilemap;
    public Tile[] grass_mid;
    public Tile[] grass_LC;
    public Tile[] grass_RC;

    public Tile grass_mud_connector_L;
    public Tile grass_mud_connector_R;

    private bool inverse = false;
    private int dir;
    private Vector3 firstPos;

    private float generationTime;
    #endregion

    void Start()
    {
        generationTime = Time.time;
        firstPos = this.transform.position;
        tilemap.SetTile(new Vector3Int ((int)transform.position.x, (int)transform.position.y, 0), grass_mid[Random.Range(0, grass_mid.Length)]);
        StartCoroutine(GenerateMud(new Vector3Int((int)transform.position.x, (int)transform.position.y, 0)));
        direction = Random.Range(1, 6);
        dir = 1;
    }

    private void Update()
    {
        if (tilesCounter < tilesNumber)
        {
            GenerateTerrain();
            //Instantiate(treeGenerator, transform.position, Quaternion.identity);
        }
        else
        {
            if (tilemap.gameObject.GetComponent<TilemapCollider2D>() == null && inverse)
            {
                tilemap.gameObject.AddComponent(typeof(TilemapCollider2D));
                Debug.Log(Time.time - generationTime);
                player.SetActive(true);
            }
            if (!inverse)
            {
                inverse = true;
                tilesCounter = 0;
                dir = -1;
                this.transform.position = firstPos - new Vector3(-1, 0, 0);
            }            
        }
    }

    #region methods
    private void GenerateTerrain()
    {
        /*if (tilesCounter >= 200 && tilesCounter <= 750 && !inZone)
        {
            inZone = true;
        }
        else
        {
            if (villageCounter == villageLarger)
            {
                inZone = false;
                villageCounter = 0;
            }
            else
            {
                villageCounter++;
            }
        }*/
        if (direction == 1 || direction == 2 || direction == 3 || direction == 4) //Move Right
        {
            Vector2 newPos = new Vector2(transform.position.x + dir * moveAmount, transform.position.y);
            transform.position = newPos;
            
            tilemap.SetTile(new Vector3Int((int)transform.position.x, (int)transform.position.y, 0), grass_mid[Random.Range(0, grass_mid.Length)]);
            Debug.Log("Generate plane at: " + transform.position);
            StartCoroutine(GenerateMud(new Vector3Int((int)transform.position.x, (int)transform.position.y, 0)));

            direction = Random.Range(1, 7);
            Debug.Log(direction);
            tilesCounter++;
        }
        if (direction == 5) //Move down
        {
            //Instantiate the corner at the same height
            Vector2 newPos = new Vector2(transform.position.x + dir * moveAmount, transform.position.y);
            transform.position = newPos;
            if (dir > 0)
            {
                tilemap.SetTile(new Vector3Int((int)transform.position.x, (int)transform.position.y, 0), grass_RC[Random.Range(0, grass_RC.Length)]);
            }
            else
            {
                tilemap.SetTile(new Vector3Int((int)transform.position.x, (int)transform.position.y, 0), grass_LC[Random.Range(0, grass_LC.Length)]);
            }
            tilesCounter++;
            Debug.Log("Generate down-pre at: " + transform.position);
            Debug.Log("Pre " + tilesCounter + ": " + transform.position.x + ", " + transform.position.y);

            //Instantiate the connector at the lower height
            newPos = new Vector2(transform.position.x, transform.position.y - moveAmount);
            transform.position = newPos;
            Debug.Log("Post " + tilesCounter + ": " + transform.position.x + ", " + transform.position.y);
            if (dir < 0) //Inverted sign
            {
                tilemap.SetTile(new Vector3Int((int)transform.position.x, (int)transform.position.y, 0), grass_mud_connector_R);
            }
            else
            {
                tilemap.SetTile(new Vector3Int((int)transform.position.x, (int)transform.position.y, 0), grass_mud_connector_L);
            }
            StartCoroutine(GenerateMud(new Vector3Int((int)transform.position.x, (int)transform.position.y, 0)));
            Debug.Log("Generate down-post at: " + transform.position);
            direction = Random.Range(1, 6);
            Debug.Log(direction);
        }
        if (direction == 6) //Move up
        {
            //Instantiate the connector at the same height
            Vector2 newPos = new Vector2(transform.position.x + dir * moveAmount, transform.position.y);
            transform.position = newPos;
            if (dir < 0)
            {
                tilemap.SetTile(new Vector3Int((int)transform.position.x, (int)transform.position.y, 0), grass_mud_connector_L);
            }
            else
            {
                tilemap.SetTile(new Vector3Int((int)transform.position.x, (int)transform.position.y, 0), grass_mud_connector_R);
            }
            StartCoroutine(GenerateMud(new Vector3Int((int)transform.position.x, (int)transform.position.y, 0)));

            Debug.Log("Generate up-pre at: " + transform.position);

            //Instantiate the corner at the upper height
            newPos = new Vector2(transform.position.x, transform.position.y + moveAmount);
            transform.position = newPos;
            if (dir > 0)
            {
                tilemap.SetTile(new Vector3Int((int)transform.position.x, (int)transform.position.y, 0), grass_LC[Random.Range(0, grass_LC.Length)]);
            }
            else
            {
                tilemap.SetTile(new Vector3Int((int)transform.position.x, (int)transform.position.y, 0), grass_RC[Random.Range(0, grass_RC.Length)]);
            }
            Debug.Log("Generate up-post at: " + transform.position);
            direction = Random.Range(1, 7);
            Debug.Log(direction);
            tilesCounter++;
        }
    }

    IEnumerator GenerateMud(Vector3Int pos)
    {
        for (int i = 0; i < mudAmount; i++)
        {
            mudTilemap.SetTile(pos - new Vector3Int(0, 1, 0), mudTiles[Random.Range(0, mudTiles.Length)]);
            pos = pos - new Vector3Int(0, 1, 0);
        }
        yield return null;
    }
    
    #endregion
}
