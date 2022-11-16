using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation : MonoBehaviour
{
    Animator animation;

    public float horizontal;


    private void Awake()
    {
        animation = GetComponentInChildren<Animator>();
    }


    private void Update()
    {
        animation.SetFloat("Horizontal", horizontal);
    }
}