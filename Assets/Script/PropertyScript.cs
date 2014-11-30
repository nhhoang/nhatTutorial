using UnityEngine;
using System.Collections;

public class PropertyScript : MonoBehaviour {

	void Start () {
		Player myPlayer = new Player();

		myPlayer.Experience = 5;
		int x = myPlayer.Experience;
		Debug.Log(x);

		myPlayer.Health = 1000;
		Debug.Log(myPlayer.Health);
	}	
}
