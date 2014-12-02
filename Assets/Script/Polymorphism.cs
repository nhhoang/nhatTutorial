using UnityEngine;
using System.Collections;

public class Polymorphism : MonoBehaviour {

	void Start () {
		Fruit myFruit = new newApple();
		myFruit.SayHello();
		myFruit.Chop();

		newApple myApple = (newApple)myFruit;
		myApple.SayHello();
		myApple.Chop();

		myFruit.SayHello();
		myFruit.Chop();
	}
}
