using UnityEngine;
using System.Collections;

public class DestroyBullet : MonoBehaviour {

    public GameObject Bullet; 
	
	// Update is called once per frame
	void Update () 
    {

        if (!GetComponent<Renderer>().isVisible)
        {
            Destroy(gameObject);
        }
	
	}
}
