using UnityEngine;
using System.Collections;

public class CreateTowerOnClick : MonoBehaviour
{
    public int NumberOfInstantiatedTowers {get; private set;}

    public int allowedNumberOfTowers;
    public TowerSelector towerselector;

    public GameObject defaultTowerPrefab;
	void Clicked(Vector3 position)
    {
        if (NumberOfInstantiatedTowers < allowedNumberOfTowers)
        {
            GameObject towerPrefabToUse;
            Debug.Log(towerselector);
            Debug.Log(towerselector.name);
            if (towerselector == null)
                towerPrefabToUse = defaultTowerPrefab;
            else
            towerPrefabToUse = towerselector.GetSelectedTower();
            Instantiate(towerPrefabToUse, position + Vector3.up * 0.5f, towerPrefabToUse.transform.rotation);
            ++NumberOfInstantiatedTowers;
        }


    }
    
    
    
    
    
 
}
