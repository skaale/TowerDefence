using UnityEngine;
using System.Collections;

public class BasicEnemy : MonoBehaviour {
    public GameObject deathListener;
	public int health = 10;



	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision collision)
	{

		if (collision.collider.tag == "Bullet" )
		{

			health--; // hver gang vi rammer en enemy trækker 1 point fra fuld health på 10 
			Destroy(collision.collider.gameObject); // vi fjerne også bullet når den rammer vores enemy
		}

		if(health <= 0)
		{

			Destroy(gameObject);

		}

	
	}

    void OnDestroy()
    {
        if (deathListener != null)
            deathListener.SendMessage("OnEnemyDied", this);
    }

}
