using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

//public struct Shape
//{
//    public string name;
//    public DateTime checkInTime;
//    public DateTime checkOutTime;
//    public int buildingId;
//}

public class ShapeFactory : MonoBehaviour
{ 
    public static ShapeFactory instance;
    public Shape square;
    public Shape circle;
    public Shape triangle;
    public RectTransform parentCanvas;
   
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
            case "square":
                Shape new_square= Instantiate(square);
                new_square.gameObject.transform.SetParent(parentCanvas.transform, false);
                break;
            case "triangle":
                Instantiate(triangle, parentCanvas.transform);
                break;
            case "circle":
                Instantiate(circle, parentCanvas.transform);
                break;
            /* you can have any number of case statements */
            default: /* optional */
                return;
        }
    }

}
