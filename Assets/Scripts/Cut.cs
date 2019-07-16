using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cut : MonoBehaviour {

    // Use this for initialization
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update () {

        if (Input.GetMouseButton(0))
        {
            RaycastHit2D hit = Physics2D.Linecast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);

            if (hit.collider != null)
            {
                if (hit.collider.tag == "Rope")
                {
                    Destroy(hit.collider.gameObject);
                }
            }
        }
    }
}
