using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] private Transform spawnlocation;
    [SerializeField] private SpawnObject objectPrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SpawnObject newObject = Instantiate(objectPrefab);
            newObject.SetColor(Random.ColorHSV(0, 1, 0.75f, 1, 0.5f, 1, 1, 1));
            newObject.transform.position = spawnLocation.position;
            newObject.transform.rotation = Random.rotation;
        }
        
    }
}
