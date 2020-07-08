using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwipeScript : MonoBehaviour
{
    Vector2 startPos, endPos, direction;
    float touchTimeStart, touchTimeFinish, timeInterval;

    [SerializeField]
    float throwForceInXandY = 1f;

    [SerializeField]
    float throwForceInZ = 50f;

    [SerializeField]
    GameObject ball;

    Rigidbody rb;

    public GameObject Panel;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();

        Panel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.touchCount>0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            touchTimeStart = Time.time;
            startPos = Input.GetTouch(0).position;
        }
        if(Input.touchCount>0 && Input.GetTouch(0).phase == TouchPhase.Ended)
        {
            touchTimeFinish = Time.time;
            timeInterval = touchTimeFinish - touchTimeStart;
            endPos = Input.GetTouch(0).position;
            direction = startPos - endPos;

            rb.isKinematic = false;
            rb.AddForce(-direction.x * throwForceInXandY, -direction.y * throwForceInXandY, throwForceInZ / timeInterval);

            //Destroy(gameObject, 3f);

        }
    }

    //축구 골대 네트에 공이 접촉되면 캔버스 띄워지게끔...
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Coll")
        {
            if (Panel != null)
            {
                Panel.SetActive(true);
            }
            //other.gameObject.SetActive(false);
            Debug.Log("Collider Success!!!");
        }
    }
}
