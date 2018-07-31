using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnerScript : MonoBehaviour {

    public GameObject enemy;
    float randx;
    Vector2 WhereToSpawn;
    public float SpawnRate = 2f;
    float NextSpawn = 0f;

	// Use this for initialization
	
	// Update is called once per frame
	void Update () {

        if(Time.time > NextSpawn)
        {
            NextSpawn = Time.time + SpawnRate;
            randx = Random.Range(-157, -121);
            WhereToSpawn = new Vector2(randx, transform.position.y);
            Instantiate(enemy, WhereToSpawn, Quaternion.identity);

        }
		
	}

    


}
