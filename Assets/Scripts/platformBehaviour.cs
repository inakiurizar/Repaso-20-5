using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platformBehaviour : MonoBehaviour
{
    public float speed;
    public bool toRight;
    GameObject clon;
    GameObject clon2;
    public GameObject baseDer;
    public GameObject baseIzq;
    public GameObject sphere;
    public GameObject cylinder;


    void Start()
    {
        toRight = true;

    }

    // Update is called once per frame
    void Update()
    {
        if (toRight)
        {
            transform.position += new Vector3(speed, 0, 0);    
        }
        else
        {
            transform.position += new Vector3(-speed, 0, 0);
        }

        if (transform.position.x > baseDer.transform.position.x - 1)
        {
            toRight = false;
            clon2 = Instantiate(cylinder);
            //Destroy(clon2, 1);
            clon2.transform.position = baseDer.transform.position + new Vector3(0,5,0);
        }

        if(transform.position.x < baseIzq.transform.position.x + 1)
        {
            toRight = true;
            clon = Instantiate(sphere);
            //Destroy(clon, 1);
            clon.transform.position = baseIzq.transform.position + new Vector3(0,5, 0);

        }

    }

  
}
