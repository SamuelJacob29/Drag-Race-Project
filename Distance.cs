using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Distance : MonoBehaviour {
    public GameObject Car;
    public GameObject FinishLine;

    public float distanceRightCar;
    public float distanceLeftCar;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        distanceRightCar = Vector3.Distance(Car.transform.position, FinishLine.transform.position);
        distanceLeftCar = Vector3.Distance(Car.transform.position, FinishLine.transform.position);

        if (distanceRightCar < 12)
        {
            Debug.Log("The Right Car won.");
        }else if(distanceLeftCar < 12)
        {
            Debug.Log("The Left Car won.");
        }
    
	}
}
