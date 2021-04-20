using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public GameObject platform;

    public void SpawnPlatform()
    {
        GameObject platformObject = Instantiate(platform);
        platformObject.transform.position = transform.position;

    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


}
