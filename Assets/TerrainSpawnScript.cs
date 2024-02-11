using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class TerrainSpawnScript : MonoBehaviour
{
    public GameObject terrain;
    public float spawn_rate;
    private float timer=10;

    public float heightOffset;
    // Start is called before the first frame update
    void Start()
    {       
        spawn_rate = 2;
        heightOffset = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if(timer < spawn_rate){
            timer += Time.deltaTime;
        }
        else{
            SpawnTerrain();
            timer=0;
        }

        if (transform.position.x < -9.2){

        }
    }

    void SpawnTerrain(){
        float lowestPoint = transform.position.y;
        float highestPoint = transform.position.y + heightOffset;
        Instantiate(terrain, new Vector3(transform.position.x, Random.Range(lowestPoint,highestPoint),0), transform.rotation);
    }
}
