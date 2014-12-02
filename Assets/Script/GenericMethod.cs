using UnityEngine;
using System.Collections;

public class GenericMethod : MonoBehaviour {

	void Start () {
		AnotherClass myClass = new AnotherClass();

		Debug.Log(myClass.GenericMethod<int>(5));
		Debug.Log(myClass.GenericMethod<string>("Hello World"));
	}	
}
