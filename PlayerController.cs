using UnityEngine;
using System.Collections;

//require this script for the character controller
[RequireComponent (typeof (CharacterController))]

//Adds the script to the components menu
[AddComponentMenu ("Control Script/PlayerController")]

public class PlayerController : MonoBehaviour
{
	public float speed = 6.0f;
	public float gravity = 20.0f;
	public float jumpSpeed = 8.0f;
	
	private Vector3 moveDirection = Vector3.zero;
	private Rigidbody rb;

	private CharacterController controller;
	
	void Start()
	{
		//Store reference to attached component
		controller = GetComponent<CharacterController>( );
	}
	
	void Update()
	{
		if (controller.isGrounded)
		{
			moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, 0);
			moveDirection = transform.TransformDirection(moveDirection);
			moveDirection *= speed;
			
			if (Input.GetButtonDown ("Jump"))
			{
				moveDirection.y = jumpSpeed;
			}
		}
	
		moveDirection.y -= gravity * Time.deltaTime;

		controller.Move (moveDirection * Time.deltaTime);
	}
}