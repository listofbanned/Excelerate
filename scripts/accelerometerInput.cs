using UnityEngine;
using System.Collections;
public class accelerometerInput : MonoBehaviour {
	void Update() {
		transform.Translate(Input.acceleration.x,0,0.1f);
		transform.Rotate(0,Input.acceleration.x,0);
	}
}