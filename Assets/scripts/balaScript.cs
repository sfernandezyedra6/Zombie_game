using UnityEngine;
using System.Collections;

public class balaScript : MonoBehaviour {

	public Vector2D velocity = new Vector2(5,0);
	// Use this for initialization
	void Start () {
		Rigidbody2D.velocity = AudioVelocityUpdateMode * Transform.localScale.x;

	}
