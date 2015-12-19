using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody))]
public class PhysicsController : MonoBehaviour {

    Vector3 savedVelocity;
    Vector3 savedAngularVelocity;

    private Rigidbody rigidbody;

    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    public void OnPauseGame()
    {
        savedVelocity = rigidbody.velocity;
        savedAngularVelocity = rigidbody.angularVelocity;
        rigidbody.isKinematic = true;
    }

    public void OnResumeGame()
    {
        rigidbody.isKinematic = false;
        rigidbody.AddForce(savedVelocity, ForceMode.VelocityChange);
        rigidbody.AddTorque(savedAngularVelocity, ForceMode.VelocityChange);
    }
}
