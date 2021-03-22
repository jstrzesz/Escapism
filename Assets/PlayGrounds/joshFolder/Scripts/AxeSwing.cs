using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AxeSwing : MonoBehaviour
{
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            GetComponent<Animation>().Play("AxeSwingAnim");
        }
    }
}
