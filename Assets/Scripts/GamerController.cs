using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GamerController : MonoBehaviour {

	public GameObject []obj;
	public GameObject player;
	public Transform cube;
	public Text time;
	public Text totalLife;
	public GameObject pausePanel;
	private float lastTime=0f,currentTime=0f;
	private float playerSpeed = 20f;

	public int blood = 5;
	private bool isMoveLeft = false;
	private bool isMoveRight = false;

	// Use this for initialization
	void Start () {
		Random.seed = 42;
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.timeScale != 0) {
			currentTime = Time.realtimeSinceStartup;

			if (currentTime - lastTime > 1f) {
				int which = Random.Range (0, 3);
				Instantiate (cube, obj [which].transform.position, Quaternion.identity);
				lastTime = Time.realtimeSinceStartup;
			}
		}
	}

	void FixedUpdate(){
		if (isMoveLeft) {
			player.transform.Translate (new Vector3 (-playerSpeed*Time.deltaTime,0,0));
		}
		if (isMoveRight) {
			player.transform.Translate (new Vector3 (playerSpeed * Time.deltaTime, 0, 0));
		}
	}

	void OnGUI(){
		if (Time.timeScale != 0) {
			time.text = Time.time.ToString ();
			totalLife.text = "Life:" + blood.ToString ();
		}
	}

	public void Damage(int damage){
		blood = blood - damage;
	}

	public void OnClickLeft(){
		isMoveLeft = true;
	}

	public void OnClickLeftUp(){
		isMoveLeft = false;
	}
		
	public void OnClickRight(){
		isMoveRight = true;
	}

	public void OnClickRightUp(){
		isMoveRight = false;
	}

	public void OnPauseGame(){
		Time.timeScale = 0;
		pausePanel.SetActive (true);
	}

	public void OnPuaseResume(){
		Time.timeScale = 1;
		pausePanel.SetActive(false);
	}

	public void OnPauseRetureMenu(){
		SceneManager.LoadScene ("MenuScene");
	}

}
