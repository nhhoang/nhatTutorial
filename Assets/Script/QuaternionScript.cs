using UnityEngine;
using System.Collections;

public class QuaternionScript : MonoBehaviour {

	public float speed = 3f;

	void Start() {
		transform.rotation = Quaternion.Euler(0.0f, 45.0f, 0.0f);
	}
}