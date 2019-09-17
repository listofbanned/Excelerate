using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class reset : MonoBehaviour {
	public void Restart() {
		SceneManager.LoadScene ("0-inicio");
	}
}