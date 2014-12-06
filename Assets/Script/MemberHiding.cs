using UnityEngine;
using System.Collections;

public class MemberHiding : MonoBehaviour {

	void Start () {

		Fruit fruit = new Fruit();
		Apple apple = new Apple();
		AmericanApple americanApple = new AmericanApple();

		fruit.SayHello();
		apple.SayHello();
		americanApple.SayHello();	
	}
}
