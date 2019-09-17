using UnityEngine;
using System.Collections;
public class end : MonoBehaviour {
	public static bool TouchWin;
	void Start() {
		TouchWin = false;
	}
	void OnTriggerEnter(Collider other) {
		if (other.gameObject.tag == "GameController") {
			TouchWin = true;
		}
	}
}