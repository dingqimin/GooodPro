using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoapToolCompoent : MonoBehaviour
{
    public float strength;
    void Start()
    {
        strength = 1;
    }
    //0-1
    public void use(float damage)
    {
        strength -= damage;
    }

    public bool destroyed()
    {
        return strength <= 0;
    }

}
