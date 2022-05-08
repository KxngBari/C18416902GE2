using UnityEngine;
public class SpawnEnemyShips : MonoBehaviour
{
    // Reference to the Prefab. Drag a Prefab into this field in the Inspector.
    public GameObject myPrefab;
    int i = 0;
    int offset = 0;
    // This script will simply instantiate the Prefab when the game starts.
    void Start()
    {
        for (i = 0; i < 30; i++)
        {
            Instantiate(myPrefab, new Vector3(206 + Random.Range(1,20), 0, 160 + Random.Range(1, 20)), Quaternion.identity);
        }
    }
}