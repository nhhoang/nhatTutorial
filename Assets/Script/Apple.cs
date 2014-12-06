using UnityEngine;
using System.Collections;

public class Apple : Fruit {

	public Apple() {
		color = "red";
		Debug.Log("1st Apple Constructor Called");
	}

	public Apple(string newColor) : base(newColor) {
		Debug.Log("2nd Apple Constructor Called");
	}

	new public void SayHello() {
		Debug.Log("Hello, I am an apple.");
	}

	public override void Talking() {
		Debug.Log("Apple is talking.");
	}
}
