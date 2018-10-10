using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour {

    Star[] stars;
    Camera cam;
    public GameObject centreOfMass;

	void Start () {
        stars = FindObjectsOfType<Star>();
        cam = GetComponent<Camera>();
    }
	
	void Update () {
        transform.position = new Vector3(centreOfMass.transform.position.x, 5, centreOfMass.transform.position.z);
        cam.orthographicSize = Vector3.Distance(stars[0].transform.position, stars[1].transform.position) + 5   ;
	}
}
