using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TowerSelector : MonoBehaviour {
	
	public GameObject[] towerIcons;
	public GameObject[] towers;
    public TowerSelector towerselector;
	public float towerIconRotateRate = 1.0f;
	
	private int selectedTower = 0;
    public GameObject defaultTowerPrefab;
	// Use this for initialization
	void Start ()
	{
		
	}
	
	// Update is called once per frame
	void Update ()
	{


        if (towerIcons.Length == 0)
        {
            defaultTowerPrefab = towerselector.GetSelectedTower();

        }else
        {
            Debug.Log(selectedTower + "; " + towerIcons.Length);
            towerIcons[selectedTower].transform.Rotate(Vector3.up, towerIconRotateRate * Time.deltaTime);
        }
       
	}
	
	public GameObject GetSelectedTower()
	{
		return towers[selectedTower];
	}
	
	public void SetSelectedTower(GameObject inputTower)
	{
		int index = 0;
		foreach(GameObject towerIcon in towerIcons)
		{
			Debug.Log(inputTower);
			if(inputTower == towerIcon)
			{
				selectedTower = index;
			}
			index++;
		}
	}
}
