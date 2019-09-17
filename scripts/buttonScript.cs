using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class buttonScript : MonoBehaviour {
	public GameObject mainCamera;
	public GameObject esfera;
	//
	public Text TimeObject;
	public static float TimeMachine;
	void Start() {
		TimeMachine = 0;
	}
	void Update() {
		//var component = GameObject.Find("Button").GetComponent<right>();
		//var _component = GameObject.Find("Button2").GetComponent<left>();
		/*
		if(component.count > 0) {
			mainCamera.transform.Rotate(0,-1,0);
			esfera.transform.Rotate(0,-1,0);
		}
		if(_component.count > 0) {
			mainCamera.transform.Rotate(0,1,0);
			esfera.transform.Rotate(0,1,0);
		}*/
		TimeMachine = TimeMachine + 1 * Time.deltaTime;
		TimeObject.text = TimeMachine.ToString();
		if (Input.GetKey(KeyCode.A)) {
			mainCamera.transform.Rotate(0, -1, 0);
			esfera.transform.Rotate(0 , -1, 0);
		}
		if (Input.GetKey(KeyCode.D)) {
			mainCamera.transform.Rotate(0, 1, 0);
			esfera.transform.Rotate(0 , 1, 0);
		}
		mainCamera.transform.Rotate(0, Input.acceleration.x, 0);
		esfera.transform.Rotate(0, Input.acceleration.x, 0);
	}
}