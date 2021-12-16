using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menu : MonoBehaviour {

	public GameObject myobject;
	public bool acitvateme;

	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update()
	{
		if (acitvateme == true)
		{
			myobject.SetActive(true);
		}
		else
		{
			myobject.SetActive(false);
		}
	}
}
