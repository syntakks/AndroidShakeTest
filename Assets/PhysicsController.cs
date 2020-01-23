using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicsController : MonoBehaviour
{
    public float ShakeForceMultiplier;
    public Rigidbody2D[] ShakingRigidBodies; 

    public void ShakeRigidBodies(Vector3 deviceAcceleration)
    {
        foreach(var rigidbody in ShakingRigidBodies)
        {
            rigidbody.AddForce(deviceAcceleration * ShakeForceMultiplier, ForceMode2D.Impulse); 
        }
    }
}
