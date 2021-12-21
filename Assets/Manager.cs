using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour {

	public int count;
	public HashSet<GameObject> Goals {get; protected set;}
	public GameObject b0F;
	public GameObject b1F;
	public GameObject b2F;
	public GameObject b3F;
	public GameObject story1;
	public GameObject story2;
	public GameObject story3;
	public GameObject story4;
	public GameObject story5;
	public bool story1Bool = false;
	public bool story2Bool = false;
	public bool story3Bool = false;
	public bool story4Bool = false;
	public bool story5Bool = false;
	public AudioSource audioSource;
	public AudioClip AudioClip;
	public AudioSource audioSource1;
	public AudioClip AudioClip1;
	public GameObject level2Building;
	public GameObject level3Building;
	public GameObject level4Building;
	public GameObject Floor;
	public Material material1;
	public Material material2;
	public Material material3;
	public Material material4;
	public Material material5;
	public GameObject tiger1;
	public GameObject tiger2;
	public void playClip()
	{
		audioSource.PlayOneShot(AudioClip);
	}
	public void playClip1()
	{
		audioSource1.PlayOneShot(AudioClip1);
	}

	// Use this for initialization
	void Start () {
		count = 0;
		Goals = new HashSet<GameObject>();
		//b0F = GameObject.FindWithTag("building");
		//b1F = GameObject.FindWithTag("building");
		//b2F = GameObject.FindWithTag("building");
		b0F.SetActive(false);
		b1F.SetActive(false);
		b2F.SetActive(false);
		//load prefabs
		//var panel = Resources.Load<GameObject>("Panel");
		//destroy
		//Object.Destory(panel);
	}
	// Update is called once per frame
	void Update () {
		count = Goals.Count;
		if( 1 == Goals.Count) {
			
			b0F.SetActive(true);
			if (story1Bool == false)
            {
				story1.SetActive(true);
				tiger1.SetActive(false);
				playClip();
				playClip1();
				Floor.GetComponent<MeshRenderer>().material = material1;
			}
				
			story1Bool = true;
			//Debug.Log("B0f");
			
		} 
		else if(2 == Goals.Count)
        {
			b1F.SetActive(true);
			if (story2Bool == false)
            {
				tiger2.SetActive(false);
				story2.SetActive(true);
				level2Building.SetActive(true);
				playClip();
				playClip1();
				Floor.GetComponent<MeshRenderer>().material = material2;
			}
				
			story2Bool = true;
			//Debug.Log("B1f");
			
		}
		else if (3 == Goals.Count)
		{
			b2F.SetActive(true);
			if (story3Bool == false)
            {
				story3.SetActive(true);
				level2Building.SetActive(false);
				level3Building.SetActive(true);
				playClip();
				playClip1();
				Floor.GetComponent<MeshRenderer>().material = material3;
			}
				
			story3Bool = true;
			//Debug.Log("B2f");
			
		}
		else if (4 == Goals.Count)
		{
			b3F.SetActive(true);
			if (story4Bool == false)
            {
				story4.SetActive(true);
				level3Building.SetActive(false);
				level4Building.SetActive(true);
				playClip();
				playClip1();
				Floor.GetComponent<MeshRenderer>().material = material4;
			}
				
			story4Bool = true;
			//Debug.Log("B2f");
			
		}
		else if (5 == Goals.Count)
		{
			if (story5Bool == false)
            {
				story5.SetActive(true);
				
				playClip();
				playClip1();
				Floor.GetComponent<MeshRenderer>().material = material5;
			}
				
			story5Bool = true;
			//Debug.Log("plat");
			
		}
		/*
				//start to count downt
				if() {
					_timeStamp = Time.realtimeSinceStartup;
				}
				//count dount
				var d = Time.realtimeSinceStartup - _timeStamp;
				Text.text = Mathf.Ceil(total - d);
				*/
	}
	
}
