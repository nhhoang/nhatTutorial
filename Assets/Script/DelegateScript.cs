using UnityEngine;
using System.Collections;

public class DelegateScript : MonoBehaviour {

	delegate void MyDelegate(int num);
	MyDelegate myDelegate;

	void Start () {
		myDelegate += PrintNum;
		myDelegate += PrintText;

		if (myDelegate != null) {
			myDelegate(50);
		}
	}

	void PrintNum(int num) {
		Debug.Log("Number = " + num);
	}

	void PrintText(int num) {
		Debug.Log("This is text.");
	}
}
