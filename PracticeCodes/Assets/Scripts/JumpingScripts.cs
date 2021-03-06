using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpingScripts : MonoBehaviour {

	Rigidbody rb;
	Renderer rend;

	public float speed = 2;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
		rend = GetComponent<Renderer> ();
	}

	void Update()
	{
//		if(Input.GetKeyDown(KeyCode.Space))
//		{
//			rb.AddForce (new Vector3 (0, 10, 0), ForceMode.Impulse);
//		}

	}

	void FixedUpdate () {
		if(Input.GetKeyDown(KeyCode.Space))
		{
			rb.AddForce (new Vector3 (0, 10, 0), ForceMode.Impulse);
		}

		if ((Input.GetAxis("Horizontal") >0 || Input.GetAxis("Horizontal") <0)  || (Input.GetAxis ("Vertical") > 0 || Input.GetAxis ("Vertical") < 0)) {
			//Debug.Log ("Into AXIS");
			float moveHorizonatal = Input.GetAxis ("Horizontal");
			float moveVertical = Input.GetAxis ("Vertical");

			Vector3 movement = new Vector3 (moveHorizonatal, 0, moveVertical);
			rb.velocity = movement * speed;
		}
	}

	void OnCollisionEnter(Collision other)
	{
		if (other.gameObject.name == "Enemy") {
			//Debug.Log ("Collided");
			//Color enemyColor = other.gameObject.getT;

			//Getting color of the Enemy

			GameObject Enemy = GameObject.Find ("Enemy");
			rend.material.color = Enemy.GetComponent<Renderer>().material.GetColor("_Color");

			//rend.material.color = Color.red;

			//The below two lines can also change the color...
//			rend.material.shader = Shader.Find("Standard");
//			rend.material.SetColor("_Color", Color.black);

		}
	}

}
