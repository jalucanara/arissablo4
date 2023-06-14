using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mapControl : MonoBehaviour
{
    Action<Vector3> onClick;
    public void RegMapClick(Action<Vector3> onClick){this.onClick = onClick;}
    void Update()
    {
        CheckMoveNewPos();
    }
    void CheckMoveNewPos()
    {
        if(!(Input.GetMouseButtonDown(0) || Input.GetMouseButtonDown(1))) return;

        RaycastHit hitInfo;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if(!Physics.Raycast(ray, out hitInfo, 100)) return;
        if(hitInfo.transform.parent != transform) return;
        if(onClick != null) onClick(hitInfo.point);   
    }
}
