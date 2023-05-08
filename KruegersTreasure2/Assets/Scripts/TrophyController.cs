using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrophyController : MonoBehaviour
{
    public static TrophyController instance;
    public Animation anim;
    List<int> trophyList = new List<int>();
    
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        if (trophyList.Count == 4)
        {
            anim.Play();
        }
    }

    public void AddTrophy(int num)
    {
        trophyList.Add(num);
    }

    public void RemoveTrophy(int num)
    {
        trophyList.Remove(num);
    }
}
