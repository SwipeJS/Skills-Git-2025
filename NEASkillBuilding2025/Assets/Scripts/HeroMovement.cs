using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroMovement : MonoBehaviour {
	Rigidbody2D rb;
	float speed;
	int lives=2;
	public void setLives(){
		lives -= 1;
		if (lives <= 0) 
		{
			Debug.Log ("End of game");
		}
	}

	// Use this for initialization
	void Start () {
		speed = 5.1f;
		rb=GetComponent<Rigidbody2D>();
	}

	void resetPosition(){
		Debug.Log("SPIKED RECEIVED!");
		transform.SetPositionAndRotation( new Vector3 (0.38f,-1.28f,0),Quaternion.identity);
		setLives ();
				}
	// Update is called once per frame
	void FixedUpdate () {
		if (Input.GetKey(KeyCode.RightArrow)|| Input.GetKey(KeyCode.LeftArrow))
		{
			transform.Translate(Input.GetAxis("Horizontal") * Time.deltaTime * speed,0,0);
		}

		if (Input.GetKeyDown(KeyCode.UpArrow))
		{
			rb.AddForce(Vector2.up * 300);
		}
	}
}
