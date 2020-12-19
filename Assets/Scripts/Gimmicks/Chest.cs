using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : MonoBehaviour
{
    // Panelをクリックされたら
    // アニメーションを再生
    Animation anim;

    private void Start()
    {
        anim = GetComponent<Animation>();
        // OnClickObj();
    }

    public void OnClickObj()
    {
        Open();
    }

    void Open()
    {
        anim.Play();
    }
}
