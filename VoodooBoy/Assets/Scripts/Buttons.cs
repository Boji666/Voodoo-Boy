using UnityEngine;
using System.Collections;

public class Buttons : MonoBehaviour {
	
	
	private bool buttonActiveW = false;
	private bool buttonActiveA = false;
	private bool buttonActiveS = false;
	private bool buttonActiveD = false;
	private bool buttonShoot = false;
	private bool buttonExit = false;

	
	// Use this for initilization	
	void Start () {
		
	}
	
	
	bool showButton(float left, float top, float width, float height, string name){
		
		
		return GUI.Button(new Rect(left,top,width,height),name);	
				 	
		
	}
	
	
	void OnGUI () { 
			
			// Show exit mesage
			GUI.Label(new Rect(10, 10, 200, 20), "Press Esc to exit.");
	
			/*
			//Show frames per second
			float time = 1.0f / Time.smoothDeltaTime;
			GUI.Label(new Rect(1280, 10, 100, 20), time.ToString() + " fps");
		*/

			// Desactive
			if (!buttonActiveW){
			
				showButton(140,460,40,40,"W");
			
			
			// Active
			}else if (buttonActiveW){
			
		 		showButton(145,465,30,30,"W");
				/*
				if ( (currentDirection > directionW || currentDirection < directionW)  && rotateW == false ){
				
					rotateW = true;
					rotateA = false;
					rotateS = false;
					rotateD = false;
					changueDirection(directionW);
									
				}
				*/				
			}
		
			if (!buttonActiveA){
			
		  		showButton(95,505,40,40,"A");
				
			
			}else if (buttonActiveA){
			
		  		showButton(100,510,30,30,"A");
				/*				
				if ( (currentDirection > directionA || currentDirection < directionA)  && rotateA == false ){
				
					
					rotateA = true;
					rotateW = false;
					rotateS = false;
					rotateD = false;
					changueDirection(directionA);
									
				}
				*/
			}
			
			if (!buttonActiveS){
			
		  		showButton(140,505,40,40,"S");
				
			}else if (buttonActiveS){
			
		  		showButton(145,510,30,30,"S");
				/*
				if ( (currentDirection > directionS || currentDirection < directionS)  && rotateS == false ){
					
					rotateS = true;
					rotateW = false;
					rotateA = false;					
					rotateD = false;
					changueDirection(directionS);
									
				}
				*/
			}
		
			if (!buttonActiveD){
			
		  		showButton(185,505,40,40,"D");
				
			
			}else if (buttonActiveD){
			
		  		showButton(190,510,30,30,"D");
				/*
				if ( (currentDirection > directionD || currentDirection < directionD) && rotateD == false ){
				
					rotateD = true;
					rotateW = false;
					rotateA = false;
					rotateS = false;					
					changueDirection(directionD);
									
				}
				*/
			}
		
			if (!buttonShoot){
			
				showButton(35,495,50,50,"Ctrl");
								
			}else if (buttonShoot){
			
		 		showButton(40,500,40,40,"Ctrl");
								
			}
		
			
	
	}
	
	
	void checkButton(){

		if (Input.GetKeyDown(KeyCode.W)){

    		buttonActiveW = true; 

  		} else if (Input.GetKeyUp(KeyCode.W)){

    		buttonActiveW = false;
			
  		}
			
		if (Input.GetKeyDown(KeyCode.A)){

    		buttonActiveA = true; 

  		} else if (Input.GetKeyUp(KeyCode.A)){

    		buttonActiveA = false;

  		}
		
		if (Input.GetKeyDown(KeyCode.S)){

    		buttonActiveS = true; 

  		} else if (Input.GetKeyUp(KeyCode.S)){

    		buttonActiveS = false;

  		}
		
		if (Input.GetKeyDown(KeyCode.D)){

    		buttonActiveD = true; 

  		} else if (Input.GetKeyUp(KeyCode.D)){

    		buttonActiveD = false;

  		}
		
		if (Input.GetKeyDown(KeyCode.LeftControl)){
			
			buttonShoot = true;
			
		}else if (Input.GetKeyUp(KeyCode.LeftControl)){
			
			buttonShoot = false;
		}
		
		if (Input.GetKeyDown (KeyCode.Escape)){
			
			buttonExit = true;
		}
		
		
	}
	
	/*
	void changueDirection(float newDirection){
				
					
		if ( currentDirection > newDirection ){
					
			float grades1 = newDirection - currentDirection;
			//Debug.Log(grades1);
			Vector3 rotate1 = new Vector3 (0,grades1,0);
			target.transform.Rotate(rotate1,Space.Self);
			
			currentDirection = newDirection;
			
					
		}else if ( currentDirection < newDirection ){
					
				float grades2 =  newDirection - currentDirection;
				//Debug.Log(grades2);
				Vector3 rotate2 = new Vector3 (0,grades2,0);
				target.transform.Rotate(rotate2,Space.Self);
				
				currentDirection = newDirection;
							
		}	
				
		
	}
	
	*/
	
	// Update is called once per frame
	void Update () {


	
		checkButton();
		
		if (buttonExit){
			Application.Quit();
		}
		  
		
	}
}
