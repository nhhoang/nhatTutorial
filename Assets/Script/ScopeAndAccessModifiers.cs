using UnityEngine;
using System.Collections;

public class ScopeAndAccessModifiers : MonoBehaviour {

	public int alpha = 5;

	private int beta = 1;
	private int gamma = 5;

	private AnotherClass myOtherClass;

	void Start() {
		alpha = 29;
		Example(beta, gamma);

		myOtherClass = new AnotherClass();
		myOtherClass.FruitMachine(alpha, myOtherClass.apples);

		AnotherClass.FruitMachineStatic(alpha, beta);
	}

	void Example(int pens, int crayons) {
		int answer;
		answer = pens * crayons * alpha;
		Debug.Log(answer);
	}

	void Update() {
		// Debug.Log("Alpha is set to: " + alpha);	
	}
}
