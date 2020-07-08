using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    public GameObject plane;
    public GameObject spawnPoint;
    public GameObject Panel;

    // Start is called before the first frame update
    void Start()
    {
        Panel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < plane.transform.position.y - 10)
        {
            transform.position = spawnPoint.transform.position;

            if (Panel != null)
            {
                Panel.SetActive(true);
            }
        }
    }
}
