using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class EnemySpawner : MonoBehaviour 
{
	public GameObject[] pathpoint; // vores path
	public GameObject[] spawnList; // vores enemy
	public float spawnTime;
    public int numberOfAllowedTowers;
    public GameObject endedListener;

    private int NumberOfSpawnedEnemiesSoFar;
    private List<BasicEnemy> AliveEnemies = new List<BasicEnemy>();
	private int SpawnIndex = 0; // vi starter med 0 

    public List<BasicEnemy> GetAliveEnemies()
    {
        return AliveEnemies;
    }

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

		if(SpawnIndex < spawnList.Length)
        {
            GameObject reference = Instantiate(spawnList[SpawnIndex], transform.position, Quaternion.identity) as GameObject;
            SpawnIndex++;
            reference.SendMessage("SetPathPoints", pathpoint);
            BasicEnemy enemyComponent = reference.GetComponent<BasicEnemy>();
            enemyComponent.deathListener = this.gameObject;
            AliveEnemies.Add(enemyComponent);
            ++NumberOfSpawnedEnemiesSoFar;
		}
        else
        {
            OnSpawningEnded();
			//Set information omkring vores Enemy

		}




	
	}

    void OnSpawningEnded()
    {
        CancelInvoke();
    }


    #region messages
    void OnEnemyDied(BasicEnemy enemy)
    {
        AliveEnemies.Remove(enemy);
        if (NumberOfSpawnedEnemiesSoFar == spawnList.Length)
        {
            if (AliveEnemies.Count == 0)
            {
                if (endedListener != null)
                    endedListener.SendMessage("WaveEnded");
            }
        }
    }
    #endregion
}
