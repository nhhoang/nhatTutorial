using UnityEngine;
using System.Collections;

public class IfStatements : MonoBehaviour {

	public float coffeeTemperature = 0f;
	float hotLimitTemperature = 70f;
	float coldLimitTemperature = 40f;

	void Update() {
		if(Input.GetKeyDown(KeyCode.Space)) {
			TemperatureTest(coffeeTemperature);
		}

		coffeeTemperature += Time.deltaTime * 5f;
	}

	void TemperatureTest(float temp) {
		if(temp > hotLimitTemperature) {
			Debug.Log("Coffee is too hot!");
		}
		else if(temp < coldLimitTemperature) {
			Debug.Log("Coffee is too cold!");
		}
		else {
			Debug.Log("Coffee is ok!");
		}
	}
}
