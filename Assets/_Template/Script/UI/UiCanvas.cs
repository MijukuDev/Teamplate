using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UiCanvas : MonoBehaviour
{
    public bool IsShow => _isShow;
    private bool _isShow = false;

    public virtual void Show(bool isShow)
    {
        gameObject.SetActive(isShow);
        _isShow = isShow;
    }

    public virtual void OnBtnBack()
    {
        Show(false);
    }    
}
