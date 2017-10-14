using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Node :
	MonoBehaviour,
	IPointerDownHandler
{
	public ShapeFactory shapefactory;
	Node () {

	}

	// Use this for initialization
	void Awake () {
		shapefactory = GameObject.Find ("Canvas").GetComponent<ShapeFactory> ();
	}

	// Update is called once per frame
	void Update () {

	}

	public void OnPointerDown(PointerEventData eventData) {
		GameObject line = shapefactory.CreateLine ();
		line.GetComponent<Line> ().SetInitialNode (this);
		Debug.Log ("Node clicked");
	}
}
