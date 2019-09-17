using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class data : MonoBehaviour {
	public int gorra;
	public int sombrilla;
	public int termo;
	public int bottle;
	public int tshirt;
	public int polo;
	public int tarjeta;
	//
	public bool winArticleGorra;
	public bool winArticleSombrilla;
	public bool winArticleTermo;
	public bool winArticleBottle;
	public bool winArticleTshirt;
	public bool winArticlePolo;
	public bool winArticleTarjeta;
	//
	private static data instanceRef;
	void Awake() {
		if (instanceRef == null) {
			instanceRef = this;
			DontDestroyOnLoad (gameObject);
		} else {
			DestroyImmediate (gameObject);
		}
	}
	void Update() {
		gorra = PlayerPrefs.GetInt ("_gorra");
		sombrilla = PlayerPrefs.GetInt ("_sombrilla");
		termo = PlayerPrefs.GetInt ("_termo");
		bottle = PlayerPrefs.GetInt ("_bottle");
		tshirt = PlayerPrefs.GetInt ("_tshirt");
		polo = PlayerPrefs.GetInt ("_polo");
		tarjeta = PlayerPrefs.GetInt ("_tarjeta");
	}
}