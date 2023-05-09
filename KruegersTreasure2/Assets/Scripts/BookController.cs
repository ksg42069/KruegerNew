using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BookController : MonoBehaviour
{
    public static BookController instance;
    List<int> bookList = new List<int>();
    
    void Start()
    {
        instance = this;
    }

    void Update()
    {
        if(bookList.Count == 4)
        {
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
