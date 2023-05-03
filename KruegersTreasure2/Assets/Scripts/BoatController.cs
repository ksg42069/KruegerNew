using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoatController : MonoBehaviour
{
    public static BoatController instance;
    List<int> wingList = new List<int>();
    public GameObject key;
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        if (wingList.Count == 2)
        {
            key.SetActive(true);
        }
    }

    public void AddWing(int num)
    {
        wingList.Add(num);
    }

    public void RemoveWing(int num)
    {
        wingList.Remove(num);
    }
}
