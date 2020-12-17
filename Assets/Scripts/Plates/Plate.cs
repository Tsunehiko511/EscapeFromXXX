using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plate : MonoBehaviour
{
    [SerializeField] Animator animator = default;
    bool isOpen = false;
    // やりたいこと
    // ・クリックすると、Openする（Animator）
    // ・もう一度クリックすると、Closeする（Animator）


    public void OnClickObj()
    {
        if (isOpen)
        {
            Close();
        }
        else
        {
            Open();
        }
    }

    void Open()
    {
        isOpen = true;
        animator.Play("PlateOpenAnim");
    }
    void Close()
    {
        isOpen = false;
        animator.Play("PlateCloseAnim");
    }
}
