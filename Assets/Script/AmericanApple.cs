using UnityEngine;
using System.Collections;

public class AmericanApple : Apple {

	new public void SayHello() {
		Debug.Log("Hello, I am an American apple.");
	}

	public override void Talking() {
		Debug.Log("American Apple is talking.");
	}
}
