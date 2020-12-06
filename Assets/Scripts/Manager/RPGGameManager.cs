using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RPGGameManager : MonoBehaviour
{
    public static RPGGameManager sharedInstance = null;

    public SpawnPoint playerSpawnPoint;
    public RPGCameraManager cameraManager;
    private void Awake()
    {
        if (sharedInstance != null && sharedInstance != this)
        {
            Destroy(gameObject);
        } else
        {
            sharedInstance = this;
        }
    }

    private void Start()
    {
        SetupScene();
    }

    public void SpawnPlayer()
    {
        if (playerSpawnPoint != null)
        {
            GameObject player = playerSpawnPoint.SpawnObject();
            cameraManager.virtualCamera.Follow = player.transform;
        }
    }
    private void SetupScene()
    {
        SpawnPlayer();
    }
}
