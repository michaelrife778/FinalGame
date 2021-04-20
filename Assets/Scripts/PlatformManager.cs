using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformManager : MonoBehaviour
{

    private float minX = -5.0f;
    private float maxX = 10.0f;

    private bool canMove;
    private float speed = 10.0f;

    private Rigidbody rigidBody;

    private bool gameOver;
    private bool ignoreCollision;
    private bool ignoreTrigger;

    void Awake()
    {
        rigidBody = GetComponent<Rigidbody>();
        rigidBody.useGravity = false;
    }
    // Start is called before the first frame update
    void Start()
    {
        canMove = true;

        if(Random.Range(0, 2) > 0)
        {
            speed *= -1f;
        }

        GameManager.instance.currentPlatform = this;
    }

    // Update is called once per frame
    void Update()
    {
        MovePlatform();
    }

    void MovePlatform()
    {
        if (canMove)
        {
            Vector3 temp = transform.position;

            temp.x += speed * Time.deltaTime;

            if(temp.x > maxX)
            {
                speed *= -1f;
            } else if (temp.x < minX)
            {
                speed *= -1f;
            }

            transform.position = temp;
        }
    }

    public void DropPlatform()
    {
        canMove = false;
        rigidBody.useGravity = true;
    }
}
