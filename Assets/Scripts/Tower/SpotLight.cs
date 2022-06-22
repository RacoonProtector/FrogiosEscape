using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpotLight : MonoBehaviour
{
    public GameObject thePlayer;
    
    void Update()
    {
        transform.LookAt(thePlayer.transform);
    }
}
