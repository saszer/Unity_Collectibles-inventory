using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using Random = UnityEngine.Random;


public class EventOnradonRange : MonoBehaviour
{
    //sz.sahaj@embracingearth.space
    
    [SerializeField] private UnityEvent callbefore;
    [SerializeField] private UnityEvent callafter;
    [SerializeField] private float min;
    [SerializeField] private float max;

    private void OnEnable()
    {
        callbefore.Invoke();
        StartCoroutine(Run());
    }

    IEnumerator Run()
    {
        yield return new WaitForSeconds(Random.Range(min, max));
        callafter.Invoke();
    }
}
