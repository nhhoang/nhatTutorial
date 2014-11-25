using UnityEngine;
using System.Collections;

public class Lerp : MonoBehaviour {

	public Vector3 posA = new Vector3(0, 0, 5);
	public Vector3 posB = new Vector3(0, 0, -5);
	public float velocity = 1;
	public Color colorA;
	public Color colorB;

	private Vector3 newPos;
	private Color newColor;

	// Use this for initialization
	void Start() {
		newPos = posA;
		colorA = Color.red;
		colorB = Color.blue;
		newColor = colorA;	
	}
	
	// Update is called once per frame
	void Update() {
		PositionChanging();
		ColorChanging();
	}

	void PositionChanging() {
		if (Input.GetKeyDown(KeyCode.Space)) {
			if (newPos == posA) {
				newPos = posB;
			} else {
				newPos = posA;
			}
		}

		transform.position = Vector3.Lerp(transform.position, newPos, velocity * Time.deltaTime);
	}

	void ColorChanging() {
		if (Input.GetKeyDown(KeyCode.C)) {
			if (newColor == colorA) {
				newColor = colorB;
			} else {
				newColor = colorA;
			}
		}

		gameObject.renderer.material.color = Color.Lerp(gameObject.renderer.material.color, newColor, velocity * Time.deltaTime);
	}
}
