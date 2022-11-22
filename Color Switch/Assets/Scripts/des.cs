using UnityEngine;
using System.Collections;

public class des : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void OnTriggerEnter(Collider other) {
		Destroy (other.gameObject);
		Application.LoadLevel ("pas");
	}
}
