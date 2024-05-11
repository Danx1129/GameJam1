using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HousePicker : MonoBehaviour
{
    // Start is called before the first frame update
    GameObject deliveryPointHolder;
    GameObject[] deliveryPoints;
    GameObject arrow;
    GameObject currentTarget;
    int counter;
    
    void Start()
    {
        deliveryPoints = deliveryPointHolder.GetComponentsInChildren<GameObject>();
        counter = Random.Range(0,deliveryPoints.Length-1);
        currentTarget = deliveryPoints[counter];
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void randomize() 
    {
        counter = Random.Range(0, deliveryPoints.Length - 1);
        currentTarget = deliveryPoints[counter];
    }
}
