using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    // どこからでもアクセスできるようにする
    public static CameraManager instance;

    [SerializeField] GameObject backButton = default;
    [SerializeField] GameObject leftButton = default;
    [SerializeField] GameObject rightButton = default;
    [SerializeField] Transform[] cameraPositions;
    Camera zoomCamera = default;
    Camera mainCamera = default;

    int currentIndex = 0;

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        mainCamera = Camera.main;
        currentIndex = 0;
        SetCameraPosition(currentIndex);
        backButton.SetActive(false);
    }

    public void TurnRight()
    {
        currentIndex++;
        if (currentIndex >= cameraPositions.Length)
        {
            currentIndex = 0;
        }
        SetCameraPosition(currentIndex);
    }

    public void TurnLeft()
    {
        currentIndex--;
        if (currentIndex < 0)
        {
            currentIndex = cameraPositions.Length - 1;
        }
        SetCameraPosition(currentIndex);
    }

    public void OnBack()
    {
        backButton.SetActive(false);
        // メインカメラに戻す = Zoomカメラを非表示&メインカメラを表示
        this.zoomCamera.gameObject.SetActive(false);
        // Camera.main.gameObject.SetActive(true); // NG
        mainCamera.gameObject.SetActive(true);
        leftButton.SetActive(true);
        rightButton.SetActive(true);
    }

    void SetCameraPosition(int index)
    {
        Camera.main.transform.position = cameraPositions[index].position;
        Camera.main.transform.rotation = cameraPositions[index].rotation;
    }

    public void SetZoomCamera(Camera zoomCamera)
    {
        this.zoomCamera = zoomCamera;
        backButton.SetActive(true);
        leftButton.SetActive(false);
        rightButton.SetActive(false);
        Camera.main.gameObject.SetActive(false);
    }

}
