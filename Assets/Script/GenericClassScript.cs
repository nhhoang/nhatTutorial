using UnityEngine;
using System.Collections;

public class GenericClassScript : MonoBehaviour {

	void Start () {
		GenericClass<int> myClass = new GenericClass<int>();
		Debug.Log(myClass.item);

		myClass.UpdateItem(5);
		Debug.Log(myClass.item);
	}	
}
