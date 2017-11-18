using UnityEngine;
using System.Collections;

public class FireballExplosion : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

	void Update(){

		GameObject[] items = GameObject.FindGameObjectsWithTag("Fireball");
		foreach(GameObject target in items){
			Destroy(target,0.75f);
		}
	}
}
