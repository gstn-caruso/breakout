using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour {
	private Rigidbody2D _rb;
	public float Velocidad = 5f;

	private void Start()
	{
		_rb = GetComponent<Rigidbody2D>();
		StartMoving();
	}

	private void StartMoving () {
		_rb.velocity = new Vector3(Random.Range(-1, 2) * Velocidad, -Velocidad);
	}

	private void OnCollisionEnter2D(Collision2D other)
	{
		Velocidad += 0.02f;
		if (other.gameObject.CompareTag("Player"))
		{
			var paddleX = other.transform.position.x;
			var ballX = gameObject.transform.position.x;
			var offsetX = ballX - paddleX;
			
			_rb.velocity = new Vector2((offsetX * 2), 1).normalized * Velocidad;
		}
	}
}
