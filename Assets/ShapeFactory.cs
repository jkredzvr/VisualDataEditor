using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public struct Shape
{
    public string name;
    public DateTime checkInTime;
    public DateTime checkOutTime;
    public int buildingId;
}

public class ShapeFactory : MonoBehaviour
{ 
    public static ShapeFactory instance;
    public Shape rectangle;
    public Shape circle;
    public Shape triange;
    public List<Shape> shapes = new List<Shape>();

    void Awake()
    {
        //Check if instance already exists
        if (instance == null)

            //if not, set instance to this
            instance = this;

        //If instance already exists and it's not this:
        else if (instance != this)

            //Then destroy this. This enforces our singleton pattern, meaning there can only ever be one instance of a GameManager.
            Destroy(gameObject);
    }
    
    void Start()
    {

        
    }

    void Update()
    {

    }

    public void CreateShape(string shapeName)
    {
        switch (shapeName)
        {
            case "rectangle":
                return Instantiate<Shape>rectangle;
                break; 
            case "triangle":
                statement(s);
                break;
            case "circle":
                statement(s);
                break;
            /* you can have any number of case statements */
            default: /* Optional */
                return null;
        }
    }

}
