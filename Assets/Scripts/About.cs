using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class About : MonoBehaviour {

	public void OnButtonBackClick(){
		SceneManager.LoadScene ("MenuScene");
	}
}
