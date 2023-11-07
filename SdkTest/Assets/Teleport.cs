﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Teleport : MonoBehaviour
{

    float offset = 1.0f;

    GameObject player;

    public void Start()
    {
        this.player = GameObject.Find("Player");
    }

    public void TeleportMove(BaseEventData data)
    {
        if (Singleton2.instance.getMode() == ModePlayer.Teleport) {
        PointerEventData pointData = data as PointerEventData;
        
        Vector3 toTeleport = pointData.pointerPressRaycast.worldPosition; //posizione assoluta

        Debug.Log(toTeleport);
        
        this.player.transform.position = new Vector3 (toTeleport.x, this.player.transform.position.y, toTeleport.z);
        }
    }


}

