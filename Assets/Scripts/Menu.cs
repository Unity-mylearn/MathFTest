using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {

	public void OnBeginGame(){
		SceneManager.LoadScene ("GameScene");
	}

	public void OnAboutGame(){
		SceneManager.LoadScene ("AboutScene");
	}

	public void OnExitGame(){
		Application.Quit ();
	}
}
