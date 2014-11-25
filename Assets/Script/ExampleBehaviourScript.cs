using UnityEngine;
using System.Collections;

public class ExampleBehaviourScript : MonoBehaviour {

	void Update() {
		if (Input.GetKeyDown(KeyCode.R)) {
			gameObject.renderer.material.color = Color.red;
		}	
	}
}
