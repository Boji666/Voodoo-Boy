using UnityEngine;
using System.Collections;

public class MoveWASD : MonoBehaviour {
	
	public float speed;
	protected Animator animator;
	public float gravity = 20.0F;
	private Vector3 moveDirection = Vector3.zero;
	private CharacterController controller;
	public Transform transf;
	//public float jumpSpeed = 8.0F; 

	private bool buttonActiveW = false;
	private bool buttonActiveA = false;
	private bool buttonActiveS = false;
	private bool buttonActiveD = false;

	// Use this for initialization
	void Start () {
		
		animator = GetComponent<Animator>();
		controller = GetComponent<CharacterController>();
	}

	// palyer Movement
	void MovePlayer(){

		//Feed moveDirection with input.
		float x = Input.GetAxis("Horizontal");
		float z = Input.GetAxis("Vertical");
		moveDirection = new Vector3 (x,0,z);

		//Multiply for velocity
		moveDirection = moveDirection*speed;

		//Changue speed variable animation
		animator.SetFloat("Speed", x*x*2+z*z*2);

		/*
		//Jumping
		if (Input.GetButton("Jump"))
			moveDirection.y = jumpSpeed;
		*/
			
		//Making the character move
		controller.Move(moveDirection * Time.deltaTime);



	}

	//Apply gravity to the player
	void ApplyGravity(){


		RaycastHit hit;

		//Check if the player touch the ground
		if (Physics.Raycast(transform.position, -Vector3.up, out hit)){

			float gravityForce = moveDirection.y-gravity*Time.deltaTime;
			Vector3 vectorGravity = new Vector3 (0,gravityForce,0);
			controller.Move(vectorGravity);
		}
			

	}

	//Check and face the correct direction
	void checkDirection(){

		checkButtonActive();

		//Move Forward
		if (buttonActiveW && !buttonActiveA && !buttonActiveS && !buttonActiveD){
			transform.forward = new Vector3(0f, 0f, 1f);

		// Move Backward
		}else if (buttonActiveS && !buttonActiveA && !buttonActiveW && !buttonActiveD){
				transform.forward = new Vector3(0f, 0f, -1f);

		//Move to left
		}else if (buttonActiveA && !buttonActiveS && !buttonActiveW && !buttonActiveD){
				transform.forward = new Vector3(-1f, 0f, 0f);

		//Move to right
		}else if (buttonActiveD && !buttonActiveS && !buttonActiveW && !buttonActiveA){
				transform.forward = new Vector3(1f, 0f, 0f);

		//Move Diagonal W-A
		}else if (buttonActiveW && buttonActiveA){			
				transform.forward = new Vector3(-1f, 0f, 1f);
				//Debug.Log ("diagonal W-A");

		//Move Diagonal W-D
		}else if (buttonActiveW && buttonActiveD){			
				transform.forward = new Vector3(1f, 0f, 1f);
				//Debug.Log ("diagonal W-D");

		//Move Diagonal S-A
		}else if (buttonActiveS && buttonActiveA){			
				transform.forward = new Vector3(-1f, 0f, -1f);
				//Debug.Log ("diagonal S-A");

		//Move Diagonal S-D
		}else if (buttonActiveS && buttonActiveD){		
				transform.forward = new Vector3(1f, 0f, -1f);
				//Debug.Log ("diagonal S-D");
		}

	}

	// Check the player move input
	void checkButtonActive(){
		
		if (Input.GetKeyDown(KeyCode.W)){			
			buttonActiveW = true; 		
		}else if (Input.GetKeyUp(KeyCode.W)){	
				buttonActiveW = false;	
		}
		
		if (Input.GetKeyDown(KeyCode.A)){	
			buttonActiveA = true; 	
		}else if (Input.GetKeyUp(KeyCode.A)){	
				buttonActiveA = false;	
		}
		
		if (Input.GetKeyDown(KeyCode.S)){		
			buttonActiveS = true; 		
		}else if (Input.GetKeyUp(KeyCode.S)){		
				buttonActiveS = false;
		}
		
		if (Input.GetKeyDown(KeyCode.D)){	
			buttonActiveD = true; 		
		} else if (Input.GetKeyUp(KeyCode.D)){
				buttonActiveD = false;			
		}
		
	}


	// Update is called once per frame
	void Update () {

		checkDirection();
		MovePlayer();
		ApplyGravity();

					
	}
	

}
