using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ChooseDestinationScript : MonoBehaviour
{
    [SerializeField] private Transform spider;
    private NavMeshAgent agent;

    private void Start() {
        agent = spider.GetComponent<NavMeshAgent>();
    }

    private void Update() {
        if(Input.GetMouseButton(0))
        {
            agent.destination = ChoosePosition();
        }
    }

    private Vector3 ChoosePosition()
    {
        RaycastHit hit;
        if(Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit))
        {
            Debug.Log(hit.point);
            return hit.point;
        }
        return Vector3.zero;
    }
}
