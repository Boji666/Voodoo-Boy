using UnityEngine;
using System.Collections;

public class MouseMovement : MonoBehaviour {
	
	public float speed2 = 30.0f; // speed at which we move

    private Vector3 target2 = new Vector3(35.0f,6.0f,70.0f);// what we hold the target in
	
	// Use this for initialization
	void Start () {
		 
	}
	
	// Update is called once per frame
	void Update () {

		
		
			
		// if you click the mouse down, figure out where we clicked.

        if (Input.GetMouseButtonDown(0)) {

            RaycastHit hit;

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if(Physics.Raycast(ray, out hit, 1000.0f)) {

                target2 = new Vector3(hit.point.x+20, 6.0f, hit.point.z+20);
				
            }
        }

        //if(target2 != null){

		     // collect the difference between the target and position
		
		     Vector3 diff = target2 - transform.position;
		
			 // set the direction to the diff's normalized direction
			
			 Vector3 dir = diff.normalized;
			
			 // set the max move amount
			
			 float moveAmount = speed2 * Time.deltaTime;
			
			 // if the max move amount is greater then what we have left, only use what we have left.
			
			 if(diff.magnitude < moveAmount)moveAmount = diff.magnitude;
			
			 // translate the move amount
	
			 transform.Translate(dir.x,dir.y,dir.z * moveAmount, Space.World);
			
		//}
        
	}
	
	 IEnumerator WaitOwnerMove() {
        print(Time.time);
        yield return new WaitForSeconds(5);
        print(Time.time);
    }
	
	
}
