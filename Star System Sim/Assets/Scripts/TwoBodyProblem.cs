using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TwoBodyProblem : MonoBehaviour {

    public Star star1, star2;

    public float totalMass;

	void Start () { 
        
	}
	
	void Update () {

        totalMass = star1.mass + star2.mass;
        Vector3 centerOfMass = star1.mass / totalMass * star1.transform.position + star2.mass / totalMass * star2.transform.position;
        transform.position = centerOfMass;
        Debug.Log(centerOfMass.ToString());

        float dist = Vector3.Distance(star1.transform.position, star2.transform.position);
        float gravConst = (float) 6.674 * Mathf.Pow(10, -1);
        float velocity1 = Mathf.Sqrt(gravConst*(totalMass/star1.mass+dist));
        float velocity2 = Mathf.Sqrt(gravConst * (totalMass / star1.mass + dist));

        star1.transform.RotateAround(centerOfMass, Vector3.up, velocity1);
        star2.transform.RotateAround(centerOfMass, Vector3.up, velocity2);

    }
}
