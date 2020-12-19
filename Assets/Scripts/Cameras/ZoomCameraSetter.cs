using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoomCameraSetter : MonoBehaviour
{
    [SerializeField] Camera zoomCamera = default;

    // クリックされたら、ズーム用にカメラに切り替える
    public void OnClickObj()
    {
        // CameraManagerに使いたいカメラを渡す
        Debug.Log("カメラをズーム");
        zoomCamera.gameObject.SetActive(true);
        CameraManager.instance.SetZoomCamera(zoomCamera);
    }
}
