using UnityEngine;
using System.Collections;

public class UpdateAndFixedUpdate : MonoBehaviour {

	void Update() {
		Debug.Log("Update time: " + Time.deltaTime);	
	}

	void FixedUpdate() {
		Debug.Log("FixedUpdate time: " + Time.deltaTime);	
	}	
}
