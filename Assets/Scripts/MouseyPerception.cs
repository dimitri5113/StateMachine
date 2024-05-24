using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class MouseyPerception : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private GameObject pawn;
    private Vector3 checkDirection;
    [SerializeField] private float distance;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void CheckDistance()
    {
        checkDirection = player.transform.position - pawn.transform.position;
        RaycastHit hit;

        if(Physics.Raycast(pawn.transform.position, checkDirection, out hit, distance)) 
        {
            if(hit.collider.gameObject.GetComponent<PlayerController>()) 
            {
                pawn.GetComponent<MouseyController>().IsJoyfulJump = true;
            }
            else
            {
                pawn.GetComponent<MouseyController>().IsJoyfulJump = false;
            }
        }
        else
        {
            pawn.GetComponent<MouseyController>().IsJoyfulJump = false;
        }

    }
}
