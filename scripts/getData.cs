using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class getData : MonoBehaviour {
	public Text gorraTxt;
	public Text sombrillaTxt;
	public Text termoTxt;
	public Text bottleTxt;
	public Text tshirtTxt;
	public Text poloTxt;
	public Text tarjetaTxt;
	void Start() {
		var getDataFromScript = GameObject.Find ("DATA").GetComponent <data>();
		gorraTxt.text = getDataFromScript.gorra.ToString();
		sombrillaTxt.text = getDataFromScript.sombrilla.ToString();
		termoTxt.text = getDataFromScript.termo.ToString();
		bottleTxt.text = getDataFromScript.bottle.ToString();
		tshirtTxt.text = getDataFromScript.tshirt.ToString();
		poloTxt.text = getDataFromScript.polo.ToString();
		tarjetaTxt.text = getDataFromScript.tarjeta.ToString();
	}
}