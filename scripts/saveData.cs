using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class saveData : MonoBehaviour {
	public GameObject alert;
	public Text alertTxt;
	//
	public InputField gorraInput;
	public InputField sombrillaInput;
	public InputField termoInput;
	public InputField bottleInput;
	public InputField tshirtInput;
	public InputField poloInput;
	public InputField tarjetaInput;
	void Start() {
		alert.SetActive (false);
		//
		var getData = GameObject.Find ("DATA").GetComponent <data>();
		gorraInput.text = getData.gorra.ToString();
		sombrillaInput.text = getData.sombrilla.ToString();
		termoInput.text = getData.termo.ToString();
		bottleInput.text = getData.bottle.ToString();
		tshirtInput.text = getData.tshirt.ToString();
		poloInput.text = getData.polo.ToString();
		tarjetaInput.text = getData.tarjeta.ToString();
	}
	public void Action() {
		StartCoroutine ("ModifyValue");
	}
	public IEnumerator ModifyValue() {
		alert.SetActive (true);
		PlayerPrefs.SetInt ("_gorra", int.Parse (gorraInput.text));
		PlayerPrefs.SetInt ("_sombrilla", int.Parse (sombrillaInput.text));
		PlayerPrefs.SetInt ("_termo", int.Parse (termoInput.text));
		PlayerPrefs.SetInt ("_bottle", int.Parse (bottleInput.text));
		PlayerPrefs.SetInt ("_tshirt", int.Parse (tshirtInput.text));
		PlayerPrefs.SetInt ("_polo", int.Parse (poloInput.text));
		PlayerPrefs.SetInt ("_tarjeta", int.Parse (tarjetaInput.text));
		alertTxt.text = "Datos guardados!.\nPor favor, aguarde 3 segundos...";
		yield return new WaitForSeconds (1);
		alertTxt.text = "Datos guardados!.\nPor favor, aguarde 2 segundos...";
		yield return new WaitForSeconds (1);
		alertTxt.text = "Datos guardados!.\nPor favor, aguarde 1 segundo...";
		yield return new WaitForSeconds (1);
		SceneManager.LoadScene ("0-inicio");
	}
}