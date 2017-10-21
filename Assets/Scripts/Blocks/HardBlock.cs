using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HardBlock : MonoBehaviour
{

	public bool IsWeak = false;
	
	private void OnCollisionEnter2D(Collision2D other)
	{
		if (other.gameObject.CompareTag("Ball"))
		{
			GetComponent<AudioSource>().Play();
			if (IsWeak)
			{
				GetComponent<Renderer>().enabled = false;
				Destroy(gameObject, 0.5f);
			}

			IsWeak = true;
		}
	}
}
