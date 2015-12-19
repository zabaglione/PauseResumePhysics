using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour {

    public void Pause()
    {
        GameObject[] objs = GameObject.FindGameObjectsWithTag("Rigidbody");
        foreach(var obj in objs)
        {
            PhysicsController pc = obj.GetComponent<PhysicsController>();
            pc.OnPauseGame();
        }
    }

    public void Resume()
    {
        GameObject[] objs = GameObject.FindGameObjectsWithTag("Rigidbody");
        foreach (var obj in objs)
        {
            PhysicsController pc = obj.GetComponent<PhysicsController>();
            pc.OnResumeGame();
        }
    }
}
