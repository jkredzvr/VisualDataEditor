﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Shape :
    MonoBehaviour,
    IDraggable,
    IPointerDownHandler,
    IPointerUpHandler
{

    public bool isDragging { get; set; }

	// Use this for initialization
	void Start () {
		isDragging = true;
	}
	
	// Update is called once per frame
	void Update () {
		if (isDragging) {
            gameObject.transform.position = Input.mousePosition;
        }
	}

    public void toggleIsDragging () {
        //isDragging = !isDragging;
    }

    public void OnPointerDown (PointerEventData eventData) {
        isDragging = true;
        //toggleIsDragging ();
    }

    public void OnPointerUp (PointerEventData eventData) {
        isDragging = false;
        //toggleIsDragging ();
        Debug.Log("not dragging");
    }
}
