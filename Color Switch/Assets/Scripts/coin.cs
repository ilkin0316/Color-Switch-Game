using UnityEngine;
using System.Collections;

public class coin : MonoBehaviour
{
	public int scoreValue;
	void OnTriggerEnter()
	{
		Destroy(transform.gameObject);
		Scoremanager.score += scoreValue = 1;
	}

	// Update is called once per frame
	void Update()
	{

	}
}