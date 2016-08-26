using UnityEngine;
using System.Collections;

public class MoveToObject : MonoBehaviour 
{
    public GameObject[] pathpoint;

    public float speed = 1.0f;

    //public float goldSize  = 0.1f; 

    private int currentpathIndex = 0;
    private Vector3 movementdirection;
    private Rigidbody attachedRigidBody;
    
	// Use this for initialization
	void Start ()  
    {
        attachedRigidBody = GetComponent<Rigidbody>();
       movementdirection = (pathpoint[currentpathIndex].transform.position - transform.position).normalized; // sætter vores start position
	
	}
	
	
    
    // Update is called once per frame
	void Update()
    {

        //transform.position; // hvor er vi nu
        // pathpoint[0].transform.position; // hvor er vi på vej hen?
       

        // Movement
        //transform.position += movementdirection * speed * Time.deltaTime; // hvert sekundt 

        
    }

    void FixedUpdate()
    {
        attachedRigidBody.MovePosition(transform.position + movementdirection * speed * Time.deltaTime);
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log(other);
        if(other.gameObject.name == pathpoint[currentpathIndex].name) // vi sammenligner navne fra vores gameobject med vores første index i arrayet
    {

            transform.position = pathpoint[currentpathIndex].transform.position; //vi sætter vores position til vores waypoint
            currentpathIndex++; // tæller +1 frem i arrayet
		if(currentpathIndex >= pathpoint.Length)
		{
			Destroy(gameObject);

		}
		else // vi får ikke outOfRange Error
		{

			movementdirection  =  (pathpoint[currentpathIndex].transform.position - transform.position).normalized;

		}       

                
                
    }
           
	


    }

	void SetPathPoints(GameObject[] inputpathPoint)
	{


		pathpoint = inputpathPoint;

	}
	
}
