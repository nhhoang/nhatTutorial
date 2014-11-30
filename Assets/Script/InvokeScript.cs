using UnityEngine;
using System.Collections;

public class InvokeScript : MonoBehaviour {

	public GameObject target;

	void Start() {
		// Invoke ("SpawnObject", 2.0f);
		InvokeRepeating("SpawnObject", 2.0f, 1.0f);	
	}
	
	void SpawnObject() {
		Instantiate(target, new Vector3(Random.Range(-2.0f, 2.0f), 0, Random.Range(-2.0f, 2.0f)), Quaternion.identity);
	}
}
