using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BookController : MonoBehaviour
{
    //public GameObject aniDoors;
    public static BookController instance;
    List<int> bookList = new List<int>();
    // Start is called before the first frame update
    void Start()
    {
        //aniDoors = GetComponent<GameObject>();
        //aniDoors = gameObject;
        instance = this;

    }

    // Update is called once per frame
    void Update()
    {
        if(bookList.Count == 4)
        {
            //aniDoors.GetComponent<Animator>().Play("opendoor");
            this.GetComponent<Animator>().Play("opendoor");
        }
    }

    public void AddBook(int num)
    {
        bookList.Add(num);
    }

    public void RemoveBook(int num)
    {
        bookList.Remove(num);
    }
}
