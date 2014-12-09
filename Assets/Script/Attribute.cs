using UnityEngine;
using System.Collections;

[ExecuteInEditMode]
public class Attribute : MonoBehaviour {

	[Range(-10.0f, 10.0f)] public float high;

	void Update() {
		transform.position = new Vector3(0.0f, high, 0.0f);
	}
}
