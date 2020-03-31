using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arrayRandom : MonoBehaviour
{
    public string[] names = { "A", "B", "C", "D", "E" };
    public int[] ages = { 1, 2, 3, 4, 5 };
    public string[] cars = { "a", "b", "c", "d", "e" };

    public int randomID;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            randomID = Random.Range(0, names.Length);
            print(randomID);
            print("Name: " + name[randomID] + "Age: " + ages[randomID] + "  Car:  " + cars[randomID]);
        }
    }
}
