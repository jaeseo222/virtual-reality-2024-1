using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class W04_Trigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        print(gameObject.name);
    }
}
