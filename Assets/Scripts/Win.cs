using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class Win : MonoBehaviour
{
    [SerializeField]
    private GameObject win;

    [SerializeField]
    private GameObject Confetti;

    AudioSource _victorySound;

    private void Awake()
    {
        _victorySound = GetComponent<AudioSource>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        win.SetActive(true);
        Confetti.SetActive(true);
        _victorySound.Play();
    }

    public void OpenNewPage()
    {
        Application.OpenURL("https://tinyurl.com/4k44rurb");
    }
}
