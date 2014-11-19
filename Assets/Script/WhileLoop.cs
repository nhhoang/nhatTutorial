using UnityEngine;
using System.Collections;

public class WhileLoop : MonoBehaviour {

	public int numEnemies = 3;
	void Start () {
		while(numEnemies > 0) {
			Debug.Log("Killed enemy number " + numEnemies + "!");
			numEnemies--;
		}
	}	
}
