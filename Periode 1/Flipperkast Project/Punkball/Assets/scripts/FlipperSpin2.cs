using UnityEngine;
using System.Collections;

public class FlipperSpin2 : MonoBehaviour {

    public float flipperstrength;
    public float pushforce;
    private HingeJoint hinge;


    void Start()
    {
        hinge = GetComponent<HingeJoint>(); //dit roept de HingeJoint op
    }

    // Update is called once per frame
    void Update() // dit zorgt ervoor dat de hinge d.m.v Z word bewogen.
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            Vector3 f = -transform.up * flipperstrength;
            Vector3 p = (transform.right) + transform.position * pushforce;
            GetComponent<Rigidbody>().AddForceAtPosition(f, p);
        }

    }
}
