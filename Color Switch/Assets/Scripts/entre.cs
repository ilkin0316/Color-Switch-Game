using UnityEngine;
using System.Collections;

public class entre : MonoBehaviour {

		// Update is called once per frame
		void OnTriggerEnter(Collider other)
		{
			Destroy(other.gameObject);
			Application.LoadLevel("pas");
		}
	}
