using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleBlock : MonoBehaviour
{
	private void OnCollisionEnter2D(Collision2D other)
	{
		if (other.gameObject.CompareTag("Ball"))
		{
			GetComponent<AudioSource>().Play();
			GetComponent<Renderer>().enabled = false;
			Destroy(gameObject, 0.5f);
		}
	}
}
