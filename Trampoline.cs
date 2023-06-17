using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trampoline : MonoBehaviour
{
    //изменяем высоту прыжка на батуте
    void OnTriggerEnter(Collider other)
    {
        Jump.jumpStrength = 10;
    }
    //возвращаем высоту прыжка после батута
    void OnTriggerExit(Collider other)
    {
        Jump.jumpStrength = 2;
    }
}
