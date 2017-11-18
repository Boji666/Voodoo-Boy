using UnityEngine;

using System.Collections;

 

public class MoveOnMouseClick : MonoBehaviour {

    public float speed; // speed at which we move

    private Vector3 target = new Vector3(35.0f,6.0f,40.0f);// what we hold the target in
	
	// Use this for initialization
	void Start () {
		
		
	}

    void Update () {
		
		
		
        // if you click the mouse down, figure out where we clicked.

        if (Input.GetMouseButton(0)) {

            RaycastHit hit;

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if(Physics.Raycast(ray, out hit, 1000.0f)) {
								
                target = new Vector3(hit.point.x, 6.0f, hit.point.z);
				
            }
			

        }
		
		
			//if(target != null){

            // collect the difference between the target and position

            Vector3 diff = target - transform.position;

            // set the direction to the diff's normalized direction

            Vector3 dir = diff.normalized;

            // set the max move amount

            float moveAmount = speed * Time.deltaTime;

            // if the max move amount is greater then what we have left, only use what we have left.

            if(diff.magnitude < moveAmount)moveAmount = diff.magnitude;

            // translate the move amount

           	//transform.LookAt (target);
			transform.Translate(dir * moveAmount, Space.World);
					
        	//}
        
        

    }

}