using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DetectCollisions : MonoBehaviour
{

    int numberOfPlatforms = 1;
    private int nextScene;

    // Start is called before the first frame update
    void Start()
    {
        nextScene = SceneManager.GetActiveScene().buildIndex + 1;
    }

    // Update is called once per frame
    void Update()
    {
        //OnTriggerEnter();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            numberOfPlatforms++;
            Destroy(gameObject);
            Destroy(other.gameObject);
            //SceneManager.LoadScene("Level 2");
            if(nextScene <= 1)
            {
                SceneManager.LoadScene(nextScene);
            }
            
        }
        
    }
}
