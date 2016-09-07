using UnityEngine;
using System.Collections;

public class CastleHealth : MonoBehaviour {

	public int health = 10;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider other) 
    {
        Debug.Log(other.gameObject.tag);

        if (other.gameObject.tag == "Enemy")
		{
			Debug.Log(tag);
			health--; // hver gang vi rammer en enemy trækker 1 point fra fuld health på 10 
			Debug.Log(tag);
			//Destroy(collision.collider.gameObject); // vi fjerne også bullet når den rammer vores enemy
		}

		if(health <= 0)
		{

			Destroy(gameObject);

		}


	}

}





