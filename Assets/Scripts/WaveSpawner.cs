using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class WaveSpawner : MonoBehaviour {
    public CreateTowerOnClick towerCreator;
    public Button startWaveButton;
    public Text currentWaveText;
    public TowerSelector towerSelector;
    List<EnemySpawner> Spawners = new List<EnemySpawner>();
    int CurrentWave = 0;
    
    void Awake()
    {
        foreach (Transform child in transform)
        {
            EnemySpawner spawnerChild = child.GetComponent<EnemySpawner>();
            spawnerChild.endedListener = this.gameObject;
            Spawners.Add(spawnerChild);
            spawnerChild.enabled = false;
        }

        UpdateNumberOfAllowedTowers();
    }

    // Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void UpdateNumberOfAllowedTowers()
    {
        towerCreator.allowedNumberOfTowers = Spawners[CurrentWave].numberOfAllowedTowers;
    }

    public void OnStartWaveButtonPressed()
    {
        startWaveButton.interactable = false;

        Spawners[CurrentWave].enabled = true;
    }

    #region messages
    // Message sent when the current wave finished
    public void WaveEnded()
    {
        Spawners[CurrentWave].enabled = false;
        

        if (CurrentWave + 1 < Spawners.Count)
        {
            ++CurrentWave;
            currentWaveText.text = CurrentWave + "";
            startWaveButton.interactable = true;
            UpdateNumberOfAllowedTowers();
           
        }
    }
    #endregion
}
