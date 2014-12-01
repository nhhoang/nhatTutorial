using UnityEngine;
using System.Collections;

public class MethodOverloading : MonoBehaviour {

	void Start () {
		int number = AnotherClass.Add(1, 2);
		Debug.Log(number);

		string str = AnotherClass.Add("Hello", "World!");
		Debug.Log(str);
	}	
}
