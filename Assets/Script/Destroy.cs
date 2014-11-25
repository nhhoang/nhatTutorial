using UnityEngine;
using System.Collections;

public class Destroy : MonoBehaviour {
	
	public GameObject cube;
	public float time;

	void Update() {		
		if (Input.GetKeyDown(KeyCode.Space)) {
			Object.Destroy(cube, time);
		}
	}
}
