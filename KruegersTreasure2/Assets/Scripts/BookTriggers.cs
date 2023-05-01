using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BookTriggers : MonoBehaviour
{
    public int ID;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Book"))
        {
            if(other.TryGetComponent<BookID>(out BookID book))
            {
                if(book.ID == ID)
                {
                    BookController.instance.AddBook(ID);
                }
            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Book"))
        {
            if (other.TryGetComponent<BookID>(out BookID book))
            {
                if (book.ID == ID)
                {
                    BookController.instance.RemoveBook(ID);
                }
            }
        }
    }
}
