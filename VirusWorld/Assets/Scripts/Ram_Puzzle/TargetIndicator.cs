﻿/*
Emilio Sanchez 
Rafael Rios
Edgar Rostro

It shows an arrow that will point towards the RAM objective at any given time until it's very near
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetIndicator : MonoBehaviour
{
    [SerializeField] Transform target;
    [SerializeField] float hideDistance;

    // Update is called once per frame
    void Update()
    {
        var dir = target.position - transform.position;
        
        if (dir.magnitude < hideDistance)
        {
            SetChildrenActive(false);
        }
        else
        {
            SetChildrenActive(true);
            var angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        }
    }

    void SetChildrenActive(bool value)
    {
        foreach (Transform child in transform)
        {
            child.gameObject.SetActive(value);
        }
    }
}
