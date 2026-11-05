using UnityEngine;

public class SpawnPrefab : MonoBehaviour
{
    public GameObject prefab;
    
    public void Spawn()
    {
        Instantiate(prefab, transform.position, transform.rotation);
    }

}
