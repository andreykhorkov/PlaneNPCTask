using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{

    public Transform sphere;
    public Transform target;
    public float initialAccel = 20;
    public float initialSpeed = 200;
    public float gravity = 9.8f;

    private Vector3 dir;
    private Vector3 stopDir;
    private Vector3 velocity;

    // Use this for initialization
    void Start ()
    {
        
	    dir = (target.position - sphere.position).normalized;
        stopDir = -Vector3.ProjectOnPlane(dir, Vector3.up);
        velocity = dir * initialSpeed;
    }
	
	// Update is called once per frame
	void Update ()
	{
	    
	    velocity += (stopDir * 5 + Vector3.down * gravity) * Time.deltaTime;
	    sphere.transform.position += velocity * Time.deltaTime;
	}
}
