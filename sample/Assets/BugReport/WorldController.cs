using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldController : MonoBehaviour
{
    [SerializeField] private Vector3 initialPosition;
    [SerializeField] private Vector3 initialRotation;
    [SerializeField] private bool hasProblem;
    // Start is called before the first frame update
    void Start()
    {
        CreateObject();
    }
    private void CreateObject()
    {
        string path = "Cylinder";
        Vector3 pos = initialPosition;
        Vector3 angle = initialRotation;

        var p = Resources.Load<GameObject>(path);
        var articulationbodies = p.GetComponentsInChildren<ArticulationBody>();
        if ((articulationbodies != null) && articulationbodies.Length > 0)
        {
            var dir = Quaternion.Euler(angle.x, angle.y, angle.z) * Vector3.forward;
            Quaternion qangle = Quaternion.LookRotation(dir);
            foreach (var articulationBody in articulationbodies)
            {
                if (articulationBody.isRoot)
                {
                    GameObject instance = null;
                    if (hasProblem)
                    {
                        //Problem code
                        instance = Instantiate(p, pos, Quaternion.identity) as GameObject;
                    }
                    else
                    {
                        //Fixed code
                        instance = Instantiate(p, pos, qangle) as GameObject;
                    }
                    articulationBody.velocity = Vector3.zero;
                    articulationBody.angularVelocity = Vector3.zero;
                    articulationBody.TeleportRoot(pos, qangle);
                    instance.name = "TEST";
                    break;
                }
            }
        }
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
