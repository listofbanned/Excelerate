using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class gameIni : MonoBehaviour {
	public void Game() {
		var setFalse = GameObject.Find ("DATA").GetComponent <data>();
		setFalse.winArticleGorra = false;
		setFalse.winArticleSombrilla = false;
		setFalse.winArticleTermo = false;
		setFalse.winArticleBottle = false;
		setFalse.winArticleTshirt = false;
		setFalse.winArticlePolo = false;
		setFalse.winArticleTarjeta = false;
		SceneManager.LoadScene("1-game");
	}
}