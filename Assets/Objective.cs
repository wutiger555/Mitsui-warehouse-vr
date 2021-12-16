using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objective : MonoBehaviour {

	protected MeshFilter meshFilter;
	public GameObject goal;
	public bool Collided = false;
	public GameObject manager;
    public Manager managerBehaviour;
	public Material Material1;
	
	//public GameObject buildingPrev;
	//public GameObject buildingAfter;

	// Use this for initialization
	void Start () {
		meshFilter = this.gameObject.GetComponent<MeshFilter>();
		//buildingPrev = GameObject.FindWithTag("building");
		//buildingAfter = GameObject.FindWithTag("building");
		//buildingAfter.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
        if (null == manager) { Debug.Log("manager exit"); return; }
        if (null == managerBehaviour)
        {
            Debug.Log("managerBehaviour exit");
            managerBehaviour = manager.GetComponent<Manager>();
        }
        //var mesh = meshFilter.sharedMesh;
        //var aabb = mesh.bounds;
        //transformation

        if (null == goal) { Debug.Log("goal exit"); return;}
		var gm = goal.GetComponent<MeshFilter>();
		if (null == gm) { Debug.Log("gm exit");  return;}
		var goalBounds = gm.sharedMesh.bounds;
		goalBounds = Transform(goalBounds, goal.transform.localToWorldMatrix);
        //var subjectBounds = Transform(mesh.bounds, this.gameObject.transform.localToWorldMatrix);
        //debug
        //Debug.Log("Goal");
        //Debug.Log(goalBounds);

        //if(!goalBounds.Intersects(subjectBounds)) {
        //	Collided = false;
        //	return;	
        //}
        var position = this.gameObject.transform.position;
        if (!goalBounds.Contains(position))
        {
			//buildingPrev.SetActive(true);
			//buildingAfter.SetActive(false);
			Collided = false;
            return;
        }
		//buildingPrev.SetActive(false);
		//buildingAfter.SetActive(true);
		Collided = true;
        managerBehaviour.Goals.Add(this.gameObject);
		
		//this.gameObject.transform.parent.gameObject.GetComponent<Rigidbody>().
		Destroy(this.gameObject);
		goal.GetComponent<MeshRenderer>().material = Material1;
		goal.GetComponent<Collider>().enabled = true;
	}

	protected virtual Bounds Transform(Bounds localBounds, Matrix4x4 t){
		var lc = localBounds.center;
		var ls = localBounds.size;
		var center = goal.transform.localToWorldMatrix * new Vector4(lc.x, lc.y, lc.z , 1);
		var size = goal.transform.localToWorldMatrix * new Vector4(ls.x, ls.y, ls.z , 0); 
		return new Bounds(center, size);
	}
}
