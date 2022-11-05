using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClockTimer : MonoBehaviour
{
    [SerializeField] private Transform clockArrow;

    void Update()
    {
        float z = 45;
        if (z >= 360)
        {
            z = 0;
        }

        z += Time.deltaTime;
        //clockArrow.rotation = new Quaternion(0,0,z);
    }
}
