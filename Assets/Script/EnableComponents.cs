using UnityEngine;
using System.Collections;

public class EnableComponents : MonoBehaviour {

	// private VectorMaths vectoMath;
	public VectorMaths vectoMath;

	// Use this for initialization
	void Start () {
		// vectoMath = GetComponent<VectorMaths>();	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyUp(KeyCode.Space)) {
			vectoMath.enabled = !vectoMath.enabled;
		}	

	}

}
