using UnityEngine;
using System.Collections;

public class TernaryOperator : MonoBehaviour {

	public int number = 5;

	void Start () {
		string message = number > 0 ? "It's positive number" : number == 0 ? "It's zero" : "It's negative number";
		Debug.Log(message);	
	}	
}
