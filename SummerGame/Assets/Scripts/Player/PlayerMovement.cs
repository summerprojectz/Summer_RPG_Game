using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Animations;

public class PlayerMovement : MonoBehaviour
{
    NavMeshAgent agent;
    public Animator anim;

    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit, Mathf.Infinity))
            {
                if (hit.transform.tag == "Enemy")
                {
                    anim.SetBool("IsCasting", true);
                }
                else
                {
                    anim.SetBool("IsCasting", false);
                    agent.SetDestination(hit.point);
                }
            }                    
        }

        if (agent.velocity == Vector3.zero)
        {
            anim.SetBool("IsWalking", false);
        }
        else
        {
            anim.SetBool("IsWalking", true);
        }
    }
}
