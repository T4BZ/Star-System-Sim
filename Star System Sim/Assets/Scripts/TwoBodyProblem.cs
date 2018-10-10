using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TwoBodyProblem : MonoBehaviour {

    Star[] stars;

    public float totalMass;

    public int level;

	void Start () {
        stars = FindObjectsOfType<Star>();
	}
	
	void Update () {

        totalMass = stars[0].mass + stars[1].mass;
        Vector3 centerOfMass = stars[0].mass / totalMass * stars[0].transform.position + stars[1].mass / totalMass * stars[1].transform.position;
        transform.position = centerOfMass;
        Debug.Log(centerOfMass.ToString());

        float dist = Vector3.Distance(stars[0].transform.position, stars[1].transform.position);
        float gravConst = (float) 6.674 * Mathf.Pow(10, -1);
        float velocity1 = Mathf.Sqrt(gravConst*(totalMass/ stars[0].mass+dist));
        float velocity2 = Mathf.Sqrt(gravConst * (totalMass / stars[0].mass + dist));

        stars[0].transform.RotateAround(centerOfMass, Vector3.up, velocity1);
        stars[1].transform.RotateAround(centerOfMass, Vector3.up, velocity2);
    }
}
