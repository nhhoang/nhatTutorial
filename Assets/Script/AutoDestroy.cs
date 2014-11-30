using UnityEngine;
using System.Collections;

public class AutoDestroy : MonoBehaviour {

	void Start() {
		Object.Destroy(gameObject, 2.0f);	
	}	
}
