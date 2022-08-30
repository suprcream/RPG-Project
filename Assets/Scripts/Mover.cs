using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class Mover : MonoBehaviour
{
    [SerializeField] Transform target;
    // ^^^^^^^^^^^    =    private & deklarasi variable dan nanti bisa muncul di unity editor
    void Update()
    {
        if(Input.GetMouseButtonDown(0)){
            MoveToCursor();
        }
    }
    private void MoveToCursor(){
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        bool hasHit = Physics.Raycast(ray, hit);
        if(hasHit){
            GetComponent<NavMeshAgent>().destination = hit.point;
        }
    }
}
