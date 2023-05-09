using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;
using Unity.XR.CoreUtils;

public class TrophyController : MonoBehaviour
{
    public static TrophyController instance;    
    List<int> trophyList = new List<int>();    
    public GameObject key;
    
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        //anim = GetComponent<Animation>();
    }

    // Update is called once per frame
    void Update()
    {
        if (trophyList.Count == 4)
        {
            key.SetActive(true);
            this.GetComponent<Animator>().Play("open");
            
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
