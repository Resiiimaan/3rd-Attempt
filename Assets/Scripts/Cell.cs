using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cell : MonoBehaviour
{
    public event EventHandler Click;

    private TMPro.TextMeshPro _prefab;

    public bool IsEnabled { get; set; } = true;

    public void SetText(string text)
    {
        if (_prefab == null)
        {
            _prefab = GetComponentInChildren<TMPro.TextMeshPro>();
        }

        _prefab.text = text;
    }

    private void OnMouseDown()
    {
        if (!IsEnabled) return;

        Click?.Invoke(this, EventArgs.Empty);
    }
}