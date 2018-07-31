using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LavaController : MonoBehaviour {

    float LifeSpan = 3f;

	// Use this for initialization
	void Start () {

        Destroy(this.gameObject, LifeSpan);

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
