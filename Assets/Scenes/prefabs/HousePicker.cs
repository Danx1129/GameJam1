using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HousePicker : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject deliveryPointHolder;
    public GameObject[] deliveryPoints;
    public GameObject arrow;
    GameObject currentTarget;
    public GameObject player;
    int counter;
    
    void Start()
    {
       
        counter = Random.Range(0,deliveryPoints.Length-1);
        currentTarget = deliveryPoints[counter];
        arrow.SendMessage("setTarget",currentTarget);
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(player.transform.position,currentTarget.transform.position) <15)
        {
            randomize();
        }
    }

    public void randomize() 
    {
        counter = Random.Range(0, deliveryPoints.Length - 1);
        currentTarget = deliveryPoints[counter];
        arrow.SendMessage("setTarget", currentTarget);
    }
}
