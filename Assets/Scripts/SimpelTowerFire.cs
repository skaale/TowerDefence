using UnityEngine;
using System.Collections;

public class SimpelTowerFire : MonoBehaviour
{

    public GameObject bullet;
    public float fireRate = 1.0f;
    public float bulletspeed = 5.0f;
    public ForceMode changeForce;
    public float fireRadius = 5f;
    // Use this for initialization
	void Start () 
    {
        InvokeRepeating("SpawnBullet", fireRate, fireRate);
	}


    
    void SpawnBullet()
    {
        // get our enemy
        //GameObject target = GameObject.FindGameObjectWithTag("Enemy");
        GameObject target = null;

        
        //use radius to fire at enemy
        foreach(Collider col in Physics.OverlapSphere(transform.position,fireRadius))
        {
            if(col.tag == "Enemy")
            {

                target = col.gameObject;
                break;
            }


        }


        if(target!= null)
        {

            //shot bullets
            GameObject newbullet = Instantiate(bullet, transform.position, bullet.transform.rotation) as GameObject;
            newbullet.GetComponent<Rigidbody>().AddForce((target.transform.position - transform.position).normalized * bulletspeed, changeForce);

        }
       

    }




	
	// Update is called once per frame
	void Update ()
    {
        
	
	}
}
