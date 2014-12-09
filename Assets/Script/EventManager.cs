using UnityEngine;
using System.Collections;

public class EventManager : MonoBehaviour {

	public delegate void ClickAction();
	public static event ClickAction OnClicked;

	void Update () {
		if (Input.GetKeyDown(KeyCode.Space)) {
			if (OnClicked != null) {
				OnClicked();
			}
		}
	}
}
