using UnityEngine;
using System.Collections;

public class SwitchScript : MonoBehaviour {

	public int number = 5;

	void Start() {
		switch (number) {
			case 1:
				Debug.Log("one");
				break;
			case 2:
				Debug.Log("two");
				break;
			case 3:
				Debug.Log("three");
				break;
			case 4:
				Debug.Log("four");
				break;
			case 5:
				Debug.Log("five");
				break;
			default:
				Debug.Log("Number is higher than five!");
				break;
		}	
	}	
}
