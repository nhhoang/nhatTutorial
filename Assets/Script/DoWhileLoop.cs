using UnityEngine;
using System.Collections;

public class DoWhileLoop : MonoBehaviour {

	public bool hello = false;
	void Update() {
		do {
				Debug.Log("Hello World!");
			}
			while(hello);		
	}
}
