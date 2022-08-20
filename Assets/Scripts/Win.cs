using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class Win : MonoBehaviour
{
    [SerializeField]
    private GameObject win;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        win.SetActive(true);
    }

    public void OpenNewPage()
    {
        Application.OpenURL("https://tinyurl.com/4k44rurb");
    }
}
