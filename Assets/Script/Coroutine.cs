using UnityEngine;
using System.Collections;

public class Coroutine : MonoBehaviour {

	public float smoothing = 1.0f;
	public Transform target;

	void Start() {
		StartCoroutine(RunTo(target));
	}

	IEnumerator RunTo(Transform target) {
		while (Vector3.Distance(transform.position, target.position) > 0.05f) {
			transform.position = Vector3.Lerp(transform.position, target.position, smoothing * Time.deltaTime);
			yield return null;
		}
		Debug.Log("Reached the target.");
		yield return new WaitForSeconds(3.0f);
		Debug.Log("MyCoroutine is finished");
	}
	
}
