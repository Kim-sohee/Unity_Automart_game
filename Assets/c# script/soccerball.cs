using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soccerball : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject plane;
    public GameObject spawnPoint;
    //public GameObject Panel;

    void Start()
    {
        //Panel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < plane.transform.position.y - 10)
        {
            transform.position = spawnPoint.transform.position;

            //Panel.SetActive(true);
        }
    }
}
