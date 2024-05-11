using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Puase : MonoBehaviour
{
    public GameObject pic;
    public GameObject Pic1;
    public GameObject Pic2;
    public GameObject Pic3;

    private void Awake()
    {
        pic.SetActive(false);
        Pic1.SetActive(false);
        Pic2.SetActive(false);
        Pic3.SetActive(false);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            pic.SetActive(true);
            Pic1.SetActive(true);
            Pic2.SetActive(true);
            Pic3.SetActive(true);
            Time.timeScale = 0f;
        }
        if (Input.GetKeyUp(KeyCode.P))
        {
            pic.SetActive(false);
            Pic1.SetActive(false);
            Pic2.SetActive(false);
            Pic3.SetActive(false);
            Time.timeScale = 1f;
        }
    }
}
