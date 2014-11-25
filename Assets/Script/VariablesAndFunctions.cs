using UnityEngine;
using System.Collections;

public class VariablesAndFunctions : MonoBehaviour {

	int myInt = 10;

	void Start() {
		myInt = MultiplyByTwo(myInt);
		Debug.Log(myInt);
	}
	
	int MultiplyByTwo(int number) {
		int temp;
		temp = number * 2;

		return temp;
	}
}
