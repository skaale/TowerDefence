using UnityEngine;
using System.Collections;
using UnityEngine.Audio;

public class EnableTrigger : MonoBehaviour {
    public AudioClip[] stings;
    public AudioSource stingSource;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            stingSource.Play();
            //PlaySting();
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
			stingSource.Stop();
           //PlaySting();
        }
    }

    void PlaySting()
    {
        int randClip = Random.Range(0, stings.Length);
        stingSource.clip = stings[randClip];
        stingSource.Play();
    }


}
