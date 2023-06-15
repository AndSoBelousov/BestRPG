using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MotionPlayer : MonoBehaviour
{
    public Camera _camera;
    public NavMeshAgent _navMesh;


    void Update()
    {
        Motion();
    }

    private void Motion()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = _camera.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                _navMesh.SetDestination(hit.point);
            }
        }
    }

}
