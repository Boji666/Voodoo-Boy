using UnityEngine;
using System.Collections;



public class Launcher : MonoBehaviour{
	

	
	public Rigidbody fireballObject;
	public float shootForce;
	public GameObject player;
	// Use this for initialization
	void Start () {

		player.GetComponents<Transform>();
		
	}
	
	
	
	void shootProjectile(){

		float shootDirection = player.transform.rotation.y;
		Quaternion newShootDirection =	new Quaternion (0f,shootDirection,0f,0f);
		float newDirection = Mathf.Round(shootDirection * 100) / 100;



		if ( Input.GetButtonUp("Fire1") && newDirection == 0 ){
			//Debug.Log("Z axis" + newDirection);
			Rigidbody newFireball = Instantiate(fireballObject, transform.position, newShootDirection) as Rigidbody;
			newFireball.AddForce(new Vector3(0f,0f,shootForce), ForceMode.Impulse);										
		
		}else if ( Input.GetButtonUp("Fire1") && newDirection == -0.71f ){
				//Debug.Log("-X axis");
				Rigidbody newFireball = Instantiate(fireballObject, transform.position, newShootDirection) as Rigidbody;
				newFireball.AddForce(new Vector3(-shootForce,0f,0f), ForceMode.Impulse);							
		
		}else if ( Input.GetButtonUp("Fire1") && newDirection == 1 ){
				//Debug.Log("Z axis" + newDirection);
				Rigidbody newFireball = Instantiate(fireballObject, transform.position, newShootDirection) as Rigidbody;
				newFireball.AddForce(new Vector3(0f,0f,-shootForce), ForceMode.Impulse);							
		
		}else if ( Input.GetButtonUp("Fire1") && newDirection == 0.71f ){
				//Debug.Log("X axis");
				Rigidbody newFireball = Instantiate(fireballObject, transform.position, newShootDirection) as Rigidbody;
				newFireball.AddForce(new Vector3(shootForce,0f,0f), ForceMode.Impulse);							
						
		}	

		
	}
	


	void Update () {
	
		shootProjectile();

	}


}
