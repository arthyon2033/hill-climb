using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gasoline : MonoBehaviour
{
    public Image gasol;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetAxis("Horizontal") > 0)
        //{
        //    gasol.fillAmount -= Input.GetAxis("Horizontal") / 10000f;
        //}
        //else
        //{
        //    gasol.fillAmount += Input.GetAxis("Horizontal") / 10000f;
        //}
        gasol.fillAmount -= Math.Abs(Input.GetAxis("Horizontal")) / 10000f;
    }

    public void AddFuel()
    {
        gasol.fillAmount += 0.3f;
    }
}
