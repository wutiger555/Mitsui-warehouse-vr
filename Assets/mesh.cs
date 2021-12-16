using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class mesh : MonoBehaviour {
	public Canvas canvas1;
	public Canvas canvas2;
	public Canvas canvas3;
	public Canvas canvas4;
	public Canvas canvas5;
	public Canvas canvas6;
	public Canvas canvas7;
	// Use this for initialization
	void Start () {
		//canvas2.enabled = false;
		//canvas3.enabled = false;
		//canvas4.enabled = false;
		//canvas5.enabled = false;
		//canvas6.enabled = false;
		//canvas7.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	int n = 0;
	
	private void OnTriggerEnter(Collider collider)
	{
		//Debug.Log("name:"+collider.name);

		//if (collider.tag == "brick")
		//{
		//	n++;
		//	Debug.Log("tag:" + collider.tag + "n:"+n);
		//	if (n == 1)
		//		canvas2.enabled = true;
		//	if (n == 2)
		//		canvas3.enabled = true;
		//	if (n == 3)
		//		canvas4.enabled = true;
		//	if (n == 4)
		//		canvas5.enabled = true;
		//	if (n == 5)
		//		canvas6.enabled = true;
		//	if (n == 6)
		//		canvas7.enabled = true;
		//}
	}
	private void OnTriggerExit(Collider collider)
	{
		//if (collider.tag == "brick")
		//{
		//	if (n == 1)
		//		canvas2.enabled = false;
		//	if (n == 2)
		//		canvas3.enabled = false;
		//	if (n == 3)
		//		canvas4.enabled = false;
		//	if (n == 4)
		//		canvas5.enabled = false;
		//	if (n == 5)
		//		canvas6.enabled = false;
		//	if (n == 6)
		//		canvas7.enabled = false;
		//	n--;
		//}
	}
}
