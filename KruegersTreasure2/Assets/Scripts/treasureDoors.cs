using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class treasureDoors : MonoBehaviour
{
    public GameObject book, doors, socket;
    //public Transform location1;
    public Animator animator;
    void Start()
    {
        book = GetComponent<GameObject>();
        doors = gameObject;
        animator = GetComponent<Animator>();

        doors.GetComponent<Animator>().Play("treasuredoor1");
    }

    // Update is called once per frame
    /*void Update()
    {
        if (Vector3.Distance(book.transform.position, socket.transform.position)<1.0f)
        {
            doors.GetComponent<Animator>().Play("treasuredoor1");
            
        }
        
    }*/
}
