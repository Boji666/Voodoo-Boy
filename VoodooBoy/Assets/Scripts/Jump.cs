using UnityEngine;
using System.Collections;

public class Jump : MonoBehaviour {
	
	public float jumpSpeed;
	private Vector3 moveDirection = Vector3.zero;
	private float gravity = 20.0f;
	private bool grounded = true;
	
	
	// Use this for initialization
	void Start () {
	
	}
	
	void Jumping(){
			
		grounded = false;
		
		
		moveDirection = new Vector3(0,transform.position.y,0);
		transform.Translate(0, moveDirection.y+5,0);
	}
	
	// Update is called once per frame
	void Update () {
		
		if (Input.GetKeyDown("space") && grounded){
						
        	Jumping();
							
    	}
		
		// Apply Gravity
		if (!grounded){
			
			moveDirection = new Vector3(0,transform.position.y,0);
			transform.Translate(0,-Time.deltaTime * gravity,0);
			
				
			if(moveDirection.y < 7){
			
			 grounded = true;
				
			}
		}
	}
	
	
	
}
