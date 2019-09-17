using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class animatorEnd : MonoBehaviour {
	public Animator cam;
	private float count;
	void Start() {
		count = 0;
		cam = GameObject.Find ("Main Camera").GetComponent<Animator> ();
	}
	void Update() {
		count = count + 1 * Time.deltaTime;
		if (count > 1.5f) {
			cam.Stop ();
		}
	}
}