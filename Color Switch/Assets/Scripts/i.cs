using UnityEngine;
using System.Collections;

public class i : MonoBehaviour {

	void Update(){
		transform.Rotate (0,0,45*Time.deltaTime);
	}
	public void Play(){
		Application.LoadLevel ("2");
	}
	public void Restart(){
		Application.LoadLevel ("2");
		Time.timeScale = 1;
	}
	public void home(){
		Application.LoadLevel ("1");
	}
}
