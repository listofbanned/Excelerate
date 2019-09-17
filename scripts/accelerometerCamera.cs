using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class accelerometerCamera : MonoBehaviour {
	private float timer;
	//
	private int winGorra;
	private int winSombrilla;
	private int winTermo;
	private int winBottle;
	private int winTshirt;
	private int winPolo;
	private int winTarjeta;
	//
	private bool setAction;
	private bool boolGorra;
	private bool boolSombrilla;
	private bool boolTermo;
	private bool boolBottle;
	private bool boolTshirt;
	private bool boolPolo;
	private bool boolTarjeta;
	//
	void Start() {
		winGorra = PlayerPrefs.GetInt ("_gorra");
		winSombrilla = PlayerPrefs.GetInt ("_sombrilla");
		winTermo = PlayerPrefs.GetInt ("_termo");
		winBottle = PlayerPrefs.GetInt ("_bottle");
		winTshirt = PlayerPrefs.GetInt ("_tshirt");
		winPolo = PlayerPrefs.GetInt ("_polo");
		winTarjeta = PlayerPrefs.GetInt ("_tarjeta");
		setAction = false;
		setAction = false;
		boolGorra = false;
		boolSombrilla = false;
		boolTermo = false;
		boolBottle = false;
		boolTshirt = false;
		boolPolo = false;
		boolTarjeta = false;
	}
	void Update() {
		if (end.TouchWin == false) {
			transform.Translate (0,0,2.231f);
		}
		// time control & action
		if (end.TouchWin == true) {
			if ((buttonScript.TimeMachine > 24.999) && (buttonScript.TimeMachine < 25.05)) {
				print (buttonScript.TimeMachine);
				setAction = true;
				if (setAction == true) {
					boolTarjeta = true;
					TimeEndFunction ();
				}
			} else if ((buttonScript.TimeMachine > 25.049) && (buttonScript.TimeMachine < 25.09)) {
				print (buttonScript.TimeMachine);
				setAction = true;
				if (setAction == true) {
					boolPolo = true;
					TimeEndFunction ();
				}
			} else if ((buttonScript.TimeMachine > 25.089) && (buttonScript.TimeMachine < 25.15)) {
				print (buttonScript.TimeMachine);
				setAction = true;
				if (setAction == true) {
					boolTshirt = true;
					TimeEndFunction ();
				}
			} else if ((buttonScript.TimeMachine > 25.149) && (buttonScript.TimeMachine < 25.19)) {
				print (buttonScript.TimeMachine);
				setAction = true;
				if (setAction == true) {
					boolSombrilla = true;
					TimeEndFunction ();
				}
			} else if ((buttonScript.TimeMachine > 25.189) && (buttonScript.TimeMachine < 25.24)) {
				print (buttonScript.TimeMachine);
				setAction = true;
				if (setAction == true) {
					boolGorra = true;
					TimeEndFunction ();
				}
			} else if ((buttonScript.TimeMachine > 25.239) && (buttonScript.TimeMachine < 25.4)) {
				print (buttonScript.TimeMachine);
				setAction = true;
				if (setAction == true) {
					boolTermo = true;
					TimeEndFunction ();
				}
			} else if (buttonScript.TimeMachine > 25.399) {
				print (buttonScript.TimeMachine);
				setAction = true;
				if (setAction == true) {
					boolBottle = true;
					TimeEndFunction ();
				}
			}
		}
	}
	private void TimeEndFunction() {
		var dataBoolChange = GameObject.Find ("DATA").GetComponent <data>();
		// action new
		if (setAction == true) {
			setAction = false;
			if (boolTarjeta == true) {
				dataBoolChange.winArticleTarjeta = true;
				winTarjeta = winTarjeta - 1;
				if (winTarjeta > 0) {
					PlayerPrefs.SetInt ("_tarjeta", winTarjeta);
					SceneManager.LoadScene ("2-final");
				} else if (winTarjeta <= 0) {
					PlayerPrefs.SetInt ("_tarjeta", 0);
					SceneManager.LoadScene ("2-final");
				}
			}
			if (boolPolo == true) {
				dataBoolChange.winArticlePolo = true;
				winPolo = winPolo - 1;
				if (winPolo > 0) {
					PlayerPrefs.SetInt ("_polo", winPolo);
					SceneManager.LoadScene ("2-final");
				} else if (winPolo <= 0) {
					PlayerPrefs.SetInt ("_polo", 0);
					SceneManager.LoadScene ("2-final");
				}}
			if (boolTshirt == true) {
				dataBoolChange.winArticleTshirt = true;
				winTshirt = winTshirt - 1;
				if (winTshirt > 0) {
					PlayerPrefs.SetInt ("_tshirt", winTshirt);
					SceneManager.LoadScene ("2-final");
				} else if (winTshirt <= 0) {
					PlayerPrefs.SetInt ("_tshirt", 0);
					SceneManager.LoadScene ("2-final");
				}}
			if (boolSombrilla == true) {
				dataBoolChange.winArticleSombrilla = true;
				winSombrilla = winSombrilla - 1;
				if (winSombrilla > 0) {
					PlayerPrefs.SetInt ("_sombrilla", winSombrilla);
					SceneManager.LoadScene ("2-final");
				} else if (winSombrilla <= 0) {
					PlayerPrefs.SetInt ("_sombrilla", 0);
					SceneManager.LoadScene ("2-final");
				}}
			if (boolGorra == true) {
				dataBoolChange.winArticleGorra = true;
				winGorra = winGorra - 1;
				if (winGorra > 0) {
					PlayerPrefs.SetInt ("_gorra", winGorra);
					SceneManager.LoadScene ("2-final");
				} else if (winGorra <= 0) {
					PlayerPrefs.SetInt ("_gorra", 0);
					SceneManager.LoadScene ("2-final");
				}}
			if (boolTermo == true) {
				dataBoolChange.winArticleTermo = true;
				winTermo = winTermo - 1;
				if (winTermo > 0) {
					PlayerPrefs.SetInt ("_termo", winTermo);
					SceneManager.LoadScene ("2-final");
				} else if (winTermo <= 0) {
					PlayerPrefs.SetInt ("_termo", 0);
					SceneManager.LoadScene ("2-final");
				}}
			if (boolBottle == true) {
				dataBoolChange.winArticleBottle = true;
				winBottle = winBottle - 1;
				if (winBottle > 0) {
					PlayerPrefs.SetInt ("_bottle", winBottle);
					SceneManager.LoadScene ("2-final");
				} else if (winBottle <= 0) {
					PlayerPrefs.SetInt ("_bottle", 0);
					SceneManager.LoadScene ("2-final");
				}
			}
		}
		//action old (in setaction true if action)
			/*
			winGorra = winGorra - 1;
			if (winGorra > 0) {
				PlayerPrefs.SetInt ("_gorra", winGorra);
			} else if (winGorra == 0) {
				PlayerPrefs.SetInt ("_gorra", 0);
				winGorra = 0;
			}*/
	}
}