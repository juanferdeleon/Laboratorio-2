using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cube : MonoBehaviour
{
    GameObject gameObject;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Z)) {
            transform.localScale += new Vector3(5, 5, 5) * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.X))
        {
            transform.localScale -= new Vector3(5, 5, 5) * Time.deltaTime;
        }
    }
}
