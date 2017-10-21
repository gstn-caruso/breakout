using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
	private Rigidbody2D _rb;
	public float Velocidad = 15f;

	private void Start()
	{
		_rb = GetComponent<Rigidbody2D>();
	}

	private void Update () {
		_rb.velocity = new Vector3(Input.GetAxis("Horizontal") * Velocidad, 0);
	}
}
