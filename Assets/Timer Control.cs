using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TimerControl : MonoBehaviour
{
    public float currT = 0f;

    public float startT;
    public TMP_Text countdownT;
    // Start is called before the first frame update
    void Start()
    {
        //countdownT = GetComponent<TextMeshPro>();
        startT = Random.Range(1, 10);
        currT = startT;
       
    }

    // Update is called once per frame
    void Update()
    {
        currT -= 1 * Time.deltaTime;
        // countdownT.color = Color.green;
        countdownT.text = currT.ToString("0");
        // if (currT <= 0)
        // {
        //     currT = 0;
        // }
    }
}
