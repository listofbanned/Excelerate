using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class winScript : MonoBehaviour {
	public Text winText;
	void Update() {
		var setDataFromBool = GameObject.Find ("DATA").GetComponent <data>();
		if (setDataFromBool.winArticleGorra = true) {
			winText = "Ganaste una gorra!";
		} else if (setDataFromBool.winArticleGorra = true) {
			winText = "Ganaste una gorra!";
		} else if (setDataFromBool.winArticleSombrilla = true) {
			winText = "Ganaste una sombrilla!";
		} else if (setDataFromBool.winArticleTermo = true) {
			winText = "Ganaste un termo!";
		} else if (setDataFromBool.winArticleBottle = true) {
			winText = "Ganaste una bottle!";
		} else if (setDataFromBool.winArticleTshirt = true) {
			winText = "Ganaste un Tshirt!";
		} else if (setDataFromBool.winArticlePolo = true) {
			winText = "Ganaste un polo!";
		} else if (setDataFromBool.winArticleTarjeta = true) {
			winText = "Ganaste una tarjeta de llamada!";
		}
	}
}