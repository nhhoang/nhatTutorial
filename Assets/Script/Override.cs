using UnityEngine;
using System.Collections;

public class Override : MonoBehaviour {

	void Start () {

		Fruit fruit = new Fruit();
		Apple apple = new Apple();
		AmericanApple americanApple = new AmericanApple();

		fruit.Talking();
		apple.Talking();
		americanApple.Talking();	
	}
}
