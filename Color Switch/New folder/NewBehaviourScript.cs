using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour {
	public GameObject PausePannel, Pausebtton;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}
	public void Pause(){
		Time.timeScale = 0;
		Pausebtton.SetActive (false);
		PausePannel.SetActive (true);
	}
	public void UnPause(){
		Pausebtton.SetActive (true);
		PausePannel.SetActive (false);
		Time.timeScale = 1;
	
	}
	public void home(){
		Application.LoadLevel ("1");
	}
}
