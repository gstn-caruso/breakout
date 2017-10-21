using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour {

	private void OnCollisionEnter2D(Collision2D other)
	{
		if (other.gameObject.CompareTag("Ball"))
		{
			GetComponent<AudioSource>().Play();
			Destroy(other.gameObject);
			SceneManager.LoadScene("GameOver", LoadSceneMode.Single);
		}
	}
}
