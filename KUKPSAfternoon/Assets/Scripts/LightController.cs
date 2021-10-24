using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightController : MonoBehaviour
{
    public Light light1;
    private void OnMouseDown()
    {
        print("Mouse Down");
        
            light1.enabled= !light1.enabled;
        
         
    }

}