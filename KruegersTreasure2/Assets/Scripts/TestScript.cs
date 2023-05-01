using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        this.GetComponent<Animator>().Play("opendoor");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
