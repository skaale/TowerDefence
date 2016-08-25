using UnityEngine;
using System.Collections;

public class EnemySpawner : MonoBehaviour 
{
	public GameObject[] pathpoint; // vores path
	public GameObject[] spawnList; // vores enemy
	public float spawnTime;

	private int SpawnIndex = 0; // vi starter med 0 
	// Use this for initialization
	void Start ()
	{

		//kald vores Spawn function med start spawnTime og derefter hvor mange gang den skal spawne
		InvokeRepeating("Spawn",0,spawnTime);
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	
	}

	void Spawn()
	{
		// Instantiate spawn enemy fra vores spawnList

		GameObject reference = Instantiate(spawnList[SpawnIndex],transform.position,Quaternion.identity) as GameObject;
		SpawnIndex++;
		if(SpawnIndex > spawnList.Length)
		{
			CancelInvoke();

		}else

		{

			//Set information omkring vores Enemy

			reference.SendMessage("SetPathPoints", pathpoint);



		}




	
	}


}
