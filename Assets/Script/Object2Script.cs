using UnityEngine;
using System.Collections;

public class Object2Script : MonoBehaviour {

	void OnEnable() {
		EventManager.OnClicked += PrintSomething;
	}

	void OnDisable() {
		EventManager.OnClicked -= PrintSomething;
	}

	void PrintSomething() {
		Debug.Log("This is object 2.");
	}
}
