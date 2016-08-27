using UnityEngine;
using System.Collections;

public class playerControl : MonoBehaviour {
	private Movement movement;
	private Rigidbody2D rb;
	public int speed;

	// Use this for initialization
	void Start () {
		movement = GetComponent<Movement>();
		rb = GetComponent<Rigidbody2D>();
	}

	// Update is called once per frame
	void Update () {

	}

	void FixedUpdate () {
		if (Input.GetButton("Right") && rb.velocity.x <= speed) {
			movement.MoveRight();
		}
		if (Input.GetButton("Left") && rb.velocity.x >= -speed) {
			movement.MoveLeft();
		}
		if (Input.GetButton("Up") && rb.velocity.y <= speed) {
			movement.MoveUp();
	  }
	  if (Input.GetButton("Down") && rb.velocity.y >= -speed) {
		  movement.MoveDown();
		}
  }
}
