using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactables_Home : MonoBehaviour
{

    // Placing object
    [SerializeField] private string compareTag;
    [SerializeField] private bool pointsGiven;

    // Pointsystem
    [SerializeField] private Pointsystem pointsystem;

    void Start()
    {
        pointsGiven = false;
    }

    // void Update()
    // {
    //     if(transform.parent.parent.name == compareTag && pointsGiven == false)
    //     {
    //         pointsGiven = true;
    //         pointsystem.add50Points();
    //         Debug.Log(transform.parent.parent);
    //     }
    // }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(compareTag) && pointsGiven == false)
        {
            pointsGiven = true;
            pointsystem.add50Points();
        }
    }
}
