using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camControl : MonoBehaviour
{
    [SerializeField] playerControl player;
    [SerializeField] float camFollowFactor = 0.1f;
    Transform playerTrans;
    Vector3 camPos;
    void Start()
    {
        BindPlayer();
    }
    void Update()
    {
        UpdateCam();
    }
    void BindPlayer()
    {
        playerTrans = player.playerTrans;
        camPos = playerTrans.position;
        transform.position = camPos;
    }
    void UpdateCam()
    {
        camPos = camPos * (1 - camFollowFactor) + playerTrans.position * camFollowFactor;
        transform.position = camPos;
    }
}
