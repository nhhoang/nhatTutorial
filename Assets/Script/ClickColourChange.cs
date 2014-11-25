using UnityEngine;
using System.Collections;

public class ClickColourChange : MonoBehaviour {


	void Start() {
		// Random.seed = (int)Time.time;
		// Debug.Log(Time.time);
		// Debug.Log(Random.seed);
	}
	
	void OnMouseDown() {
		float r = Random.Range(0f, 1f);
		float g = Random.Range(0f, 1f);
		float b = Random.Range(0f, 1f);
		Color randomColour = new Color(r, g, b, 1.0f);

		renderer.material.color = randomColour;
	}
}
