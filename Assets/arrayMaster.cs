using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arrayMaster : MonoBehaviour
{
    public string[] names = { "A", "B", "C", "D", "E" };
    public int[] ages = { 1, 2, 3, 4, 5 };
    public string[] cars = { "a", "b", "c", "d", "e" };

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            print("Name: " + name[4] + "Age: " + ages[4] + "  Car:  " + cars[4]);
        }
    }
}
