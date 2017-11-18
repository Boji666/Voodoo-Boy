using UnityEngine;
using System.Collections;

public class FollowPlayer : MonoBehaviour
{
/*
This camera smoothes out rotation around the y-axis and height.
Horizontal Distance to the target is always fixed.

There are many different ways to smooth the rotation but doing it this way gives you a lot of control over how the camera behaves.

For every of those smoothed values we calculate the wanted value and the current value.
Then we smooth it using the Lerp function.
Then we apply the smoothed values to the transform's position.
*/
	
	// The target we are following
	public Transform target;
	// The distance in the x-z plane to the target
	public float distance = 200.0f;
	// the height we want the camera to be above the target
	public float height = 150.0f;
	// How much we 
	//private float heightDamping = 2.0f;
	//private float rotationDamping = 3.0f;
	

		
		
	void LateUpdate () {

		// Early out if we don't have a target
		if (!target){

			return;

		}else{

			// Calculate the current rotation angles
			//float wantedRotationAngle = target.eulerAngles.y;
			//float currentRotationAngle = transform.eulerAngles.y;

			//float currentHeight = transform.position.y;
			float wantedHeight = target.position.y + height;

			/*
			// Damp the rotation around the y-axis
			currentRotationAngle = Mathf.LerpAngle (currentRotationAngle, wantedRotationAngle, rotationDamping * Time.deltaTime);

			// Damp the height
			currentHeight = Mathf.Lerp (currentHeight, wantedHeight, heightDamping * Time.deltaTime);
			
			// Convert the angle into a rotation
			Quaternion currentRotation = Quaternion.Euler (0, currentRotationAngle, 0);
			*/

			// Set the position of the camera on the x-z plane to:
			// distance meters behind the target
			transform.position = target.position;
			transform.position = transform.position - Vector3.forward * distance;


			// Set the height of the camera
			//transform.position.y = currentHeight;
			Vector3 newPosition = new Vector3(transform.position.x,wantedHeight,transform.position.z);
			transform.position = newPosition;
			// Always look at the target
			transform.LookAt (target);

		}
	}
}