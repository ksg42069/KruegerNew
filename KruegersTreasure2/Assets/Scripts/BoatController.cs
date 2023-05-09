using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoatController : MonoBehaviour
{
    public static BoatController instance;
    List<int> wingList = new List<int>();
    public GameObject key;
    
    void Start()
    {
        instance = this;
    }

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
