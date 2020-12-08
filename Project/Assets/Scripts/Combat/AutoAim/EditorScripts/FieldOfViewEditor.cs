﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor (typeof(FieldOFView))]
public class FieldOfViewEditor : Editor
{
    private void OnSceneGUI()
    {
        FieldOFView fow = (FieldOFView)target;
        Handles.color = Color.white;
        Handles.DrawWireArc(fow.transform.position, 
            Vector3.up, Vector3.forward, 360, fow.viewRadius);

        Vector3 viewAngleA = fow.DirFromAngle(-fow.viewAngle / 2, false);
        Vector3 viewAngleB = fow.DirFromAngle(fow.viewAngle / 2, false);

        Handles.DrawLine(
            fow.transform.position,
            fow.transform.position + viewAngleA * fow.viewRadius);

        Handles.DrawLine(
          fow.transform.position,
          fow.transform.position + viewAngleB * fow.viewRadius);

        
        Handles.color = Color.white;

        /*
        foreach (Transform visibleTarget in fow.visibleTargets)
        {
            Handles.DrawLine(fow.transform.position, visibleTarget.position);
        }
        */
        Handles.color = Color.green;

        if (fow.getClosestEnemy()) 
        Handles.DrawLine(fow.transform.position, fow.getClosestEnemy().position);
    }

    
}