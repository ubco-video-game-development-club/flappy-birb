﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform followTarget;
    public float followTime = 0.1f;
    public float xOffset = 0;

    private Vector3 currentVelocity;

    void FixedUpdate() {
        Vector3 targetPos = new Vector3(followTarget.position.x + xOffset, 0, transform.position.z);
        transform.position = Vector3.SmoothDamp(transform.position, targetPos, ref currentVelocity, followTime);
    }
}
