using UnityEngine;
using System.Collections;

public class Flipperspin : MonoBehaviour {

    public float flipperstrength;
    public float pushforce;
    private HingeJoint hinge;


	void Start () {
        hinge = GetComponent<HingeJoint>(); //dit roept een HingeJoint op.
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.RightArrow)) //Dit beweegt de HingeJoint d.m.v de M knop.
        {
            Vector3 f = transform.up * flipperstrength;
            Vector3 p = (transform.right) + transform.position * pushforce;
            GetComponent<Rigidbody>().AddForceAtPosition(f, p);
        }
	
	}
}
