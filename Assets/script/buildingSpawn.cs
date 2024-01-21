using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buildingSpawn : MonoBehaviour
{
    public GameObject buildingPrefab;
    public float respawnTime = 2f;
    public int score = 0;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(buildingWave());
    }

    private void spawnBuilding()
    {
        score += 1;
        Debug.Log(score);
        GameObject a = Instantiate(buildingPrefab) as GameObject; //clone the original object and return the clone
        a.transform.position = new Vector3(0, Random.Range(1, 6), -1); //assign the position to the cloned object, random is udes to give random position in y-axis
    }
    
    IEnumerator buildingWave()
    {
        while(true)
        {
            yield return new WaitForSeconds(respawnTime);
            spawnBuilding();
        }
    }
}
