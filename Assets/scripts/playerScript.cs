﻿using UnityEngine;
using System.Collections;

public class playerScript : MonoBehaviour {

	public float speed = 10f;
	public Vector2 maxVelocity = new Vector2(2,3);
	//public Light linterna
	private Animator animator;

	// Use this for initialization
	void Start () {
	
		animator = GetComponent<Animator> ();

	}
	
	// Update is called once per frame
	void Update () {

				var absVelX = Mathf.Abs (rigidbody2D.velocity.x);
				var forceX = 0f;
				var forceY = 0f;

				if (Input.GetKey ("right")) {
						//Esto lo que hace es frenar cuando voy a la izquierda y pulso a la derecha
						if (rigidbody2D.velocity.x < 0) {
								rigidbody2D.velocity = new Vector2 (0, rigidbody2D.velocity.y);
						}
						if (absVelX < maxVelocity.x)
								forceX = speed;
						
						//Esto pone el sprite mirando a la derecha
						this.transform.localScale = new Vector3 (1, 1, 1);

				} else if (Input.GetKey ("left")) {
						//Esto lo que hace es frenar cuando voy a la derecha y pulso izquierda
						if (rigidbody2D.velocity.x > 0)
								rigidbody2D.velocity = new Vector2 (0, rigidbody2D.velocity.y);

						if (absVelX < maxVelocity.x)
								forceX = -speed;
						//Esto pone el srpite mirando hacia la direccion inicial
						this.transform.localScale = new Vector3 (-1, 1, 1);
				}

				if (absVelX > 0)
						animator.SetFloat ("Velocity", absVelX);

				rigidbody2D.AddForce (new Vector2 (forceX, forceY));

				if (Input.GetKey ("c")) {
						animator.SetBool ("Fire", true);

				} else {
						animator.SetBool ("Fire", false);
				}
		}

}