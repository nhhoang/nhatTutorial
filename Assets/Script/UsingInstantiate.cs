using UnityEngine;
using System.Collections;

public class UsingInstantiate : MonoBehaviour {

	public Rigidbody bulletPrefab;
	public Transform gun; 

	void Update() {
		if (Input.GetKeyDown(KeyCode.Space)) {
			Rigidbody bullet;
			bullet = Instantiate(bulletPrefab, gun.position, gun.rotation) as Rigidbody;
			bullet.AddForce(gun.right * -500);
		}
	}
}
