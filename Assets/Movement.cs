using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {
	public float xStart;
	public float yStart;
	public float xSpeed;
	public float ySpeed;
	public Rigidbody2D rb;
	private double xPrevious;
	private double yPrevious;
	public ForceMode2D mode;
	public Movement character;

	// Use this for initialization
	void Start () {
		mode = ForceMode2D.Force;
		rb = GetComponent<Rigidbody2D>();
		//character = GetComponent<Movement>();
		GetComponent<Rigidbody2D>().position = new Vector3(xStart, yStart);

	}

	// Update is called once per frame
	public void Update () {
	}

	// Update is called every significant frame
	public void FixedUpdate () {
		// make this a bounding box
		xPrevious = rb.position.x;
		yPrevious = rb.position.y;
		//character.MoveUp();
		//character.MoveRight();
	}

	public void MoveUp () {
		Vector2 vector = new Vector2(0, ySpeed);
		rb.AddForce(vector, mode);
	}
	public void MoveDown () {
		Vector2 vector = new Vector2(0, -ySpeed);
		rb.AddForce(vector, mode);
	}

	public void MoveRight () {
		Vector2 vector = new Vector2(xSpeed, 0);
		rb.AddForce(vector, mode);
	}

	public void MoveLeft () {
		Vector2 vector = new Vector2(-xSpeed, 0);
		rb.AddForce(vector, mode);
	}
	public void Stop () {
		//rb.
	}
}
