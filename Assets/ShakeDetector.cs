using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(PhysicsController))]
public class ShakeDetector : MonoBehaviour
{
    public float ShakeDetectionThreshold;
    public float MinShakeInterval;
    private float sqrShakeDetectionThreshold;
    private float timeSinceLastShake;
    private PhysicsController physicsController; 


    // Start is called before the first frame update
    void Start()
    {
        sqrShakeDetectionThreshold = Mathf.Pow(ShakeDetectionThreshold, 2);
        physicsController = GetComponent<PhysicsController>(); 
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.acceleration.sqrMagnitude >= sqrShakeDetectionThreshold
            && Time.unscaledTime >= timeSinceLastShake + MinShakeInterval)
        {
            physicsController.ShakeRigidBodies(Input.acceleration);
            timeSinceLastShake = Time.unscaledTime; 
        }
    }
}
