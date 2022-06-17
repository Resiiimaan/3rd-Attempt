using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameTied : MonoBehaviour
{
    public void Show()
    {
        gameObject.SetActive(true);
        StartCoroutine(WaitForIt());
    }

    IEnumerator WaitForIt()
    {
        yield return new WaitForSeconds(3);
        gameObject.SetActive(false);
    }
}