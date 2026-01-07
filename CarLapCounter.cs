using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using System;

public class CarLapCounter : MonoBehaviour
{
    int passedCheckPointsNumber = 0;
    float timeAtLastPassedCheckPoint = 0;

    int numberOfPassedCheckPoints = 0;

    public event Action<CarLapCounter> OnPassCheckpoint;

    void OnTriggerEnter2D(Collider2D collider2D)
    {
        if(collider2D.CompareTag("CheckPoint"))
        {
            CheckPoints checkPoint = collider2D.GetComponent<CheckPoints>();

            if(passedCheckPointsNumber + 1 == checkPoint.checkpointNumber)
            {
                passedCheckPointsNumber = checkPoint.checkpointNumber;

                numberOfPassedCheckPoints++;

                timeAtLastPassedCheckPoint = Time.time;

                OnPassCheckpoint?.Invoke(this);
            }
        }
    }
}
