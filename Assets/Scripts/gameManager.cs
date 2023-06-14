using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameManager : MonoBehaviour
{
    [SerializeField] mapControl mapCtrl;
    [SerializeField] playerControl playerCtrl;
    void Start()
    {
        mapCtrl.RegMapClick(FireMapClick);
    }
    void FireMapClick(Vector3 i){playerCtrl?.OnClickMapPos(i);}

}
