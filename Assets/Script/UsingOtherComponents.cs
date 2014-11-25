using UnityEngine;
using System.Collections;

public class UsingOtherComponents : MonoBehaviour {

	public GameObject otherGameObject;

	public ScopeAndAccessModifiers anotherScript;

	private ScopeAndAccessModifiers anotherScript1;

	void Start() {
		Debug.Log(anotherScript.alpha);

		Debug.Log(otherGameObject.GetComponent<ScopeAndAccessModifiers>().alpha);

		anotherScript1 = GetComponent<ScopeAndAccessModifiers>();
		Debug.Log(anotherScript1.alpha);	

	}
	
	void Update() {
	
	}
}
