using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    // やりたいこと
    // ・カメラの回転：特定の位置に移動する

    [SerializeField] Transform[] cameraPositions;
    int currentIndex = 0;

    private void Start()
    {
        currentIndex = 0;
        SetCameraPosition(currentIndex);
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

    void SetCameraPosition(int index)
    {
        Camera.main.transform.position = cameraPositions[index].position;
        Camera.main.transform.rotation = cameraPositions[index].rotation;
    }

}
