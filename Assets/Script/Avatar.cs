using UnityEngine;
using System.Collections;

public class Avatar : MonoBehaviour, IKillable, IDamageable<float> {

	public void Kill() {
		Debug.Log("This can be killed");
	}

	public void Damage(float damageTaken) {

	}
}
