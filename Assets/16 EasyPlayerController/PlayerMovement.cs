using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {


	public CharacterController controller;

	public float speed = 12f;
	public float gravity = -9.8f;
	public float jumpHeight = 10f;

	public Transform groundCheck;
	public float groundDistance = 0.4f;
	public LayerMask groundMask;

	Vector3 velocity;

	bool isGrounded;
	
	void Update () {

		isGrounded = Physics.CheckSphere(groundCheck.position,groundDistance,groundMask);

		if (isGrounded && velocity.y<0)
		{
			velocity.y = -2f;
		}

		float x = Input.GetAxis("Horizontal");
		float z = Input.GetAxis("Vertical");

		Vector3 move = transform.right*x+transform.forward*z;

		controller.Move(move*speed*Time.deltaTime);

		if (Input.GetButtonDown("Jump") && isGrounded)
		{
			velocity.y = Mathf.Sqrt(jumpHeight*-2f*gravity);//For the jump we can use this formula v=Mathf.Sqrt H-2*g
		}

		velocity.y += gravity + Time.deltaTime;//here we use a formula  y=(1/2)*g*t^2

		controller.Move(velocity*Time.deltaTime);//here we use a formula  y=(1/2)*g*t^2

		
	}
}
