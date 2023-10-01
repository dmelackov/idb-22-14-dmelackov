using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class VisibilityToggle : MonoBehaviour
{
    public GameObject toggledObject;

    public void toogleVisible(){
        print("Event!");
        toggledObject.GetComponent<MeshRenderer>().enabled ^= true;
    }
}
