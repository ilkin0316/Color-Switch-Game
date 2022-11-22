using UnityEngine;
using System.Collections;

public class destroy : MonoBehaviour {

	void OnTriggerEnter(Collider other){
		Destroy (other.gameObject);
		Application.LoadLevel ("1");
	}
}
