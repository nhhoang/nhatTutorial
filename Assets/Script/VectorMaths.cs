using UnityEngine;
using System.Collections;

public class VectorMaths : MonoBehaviour {

	public Vector3 vector1,vector2;

	// Use this for initialization
	void Start () {
		Debug.Log(Vector3.Dot(vector1, vector2));
		Debug.Log(Vector3.Cross(vector1, vector2));	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
	