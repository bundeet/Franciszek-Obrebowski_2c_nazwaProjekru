using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class PositionHandler : MonoBehaviour
{

    public List<CarLapCounter> carLapCounters = new List<CarLapCounter>();

    // Start is called before the first frame update
    void Start()
    {
        CarLapCounter[] carLapCounterArray = FindObjectsOfType<CarLapCounter>();

        carLapCounters = carLapCounterArray.ToList<CarLapCounter>();

        foreach (CarLapCounter lapCounters in carLapCounters)
            lapCounters.OnPassCheckpoint += onPassCheckpoint;
    }

    void onPassCheckpoint(CarLapCounter carLapCounter)
    {
        Debug.Log($"Event: Car {carLapCounter.gameObject.name} passed a checkpoint");
    }

}
