using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSprite : MonoBehaviour
{
    [Header("Icons")]
    [SerializeField]
    GameObject _nocolor;
    [SerializeField]
    GameObject _redcolor;
    [SerializeField]
    GameObject _greencolor;
    [SerializeField]
    GameObject _yellowcolor;
    [SerializeField]
    GameObject _fullcolor;
    [SerializeField]
    GameObject _deltacolor;


    [Header("Animator of Color")]
    [SerializeField]
    Animator _redColorAnim;
    [SerializeField]
    Animator _greencolorAnim;
    [SerializeField]
    Animator _yellowcolorAnim;
    [SerializeField]
    Animator _fullcolorAnim;

    [Header("Animator of Selectors")]
    [SerializeField]
    Animator _leadSelectionAnim;
    [SerializeField]
    Animator _domainSelectionAnim;
    [SerializeField]
    Animator _coreteamAnim;
    [SerializeField]
    Animator _webStrike;
    [SerializeField]
    Animator _LaunchAnim;

    bool _isNoColor;
    bool _isRedColor;
    bool _isGreenColor;
    bool _isYellowColor;
    bool _isFullColor;
    bool _isDeltaColor;

    private void Start()
    {
        _isDeltaColor = true;
        SetSprite();
    }

    private void SetSprite()
    {
        _nocolor.SetActive(_isNoColor);
        _redcolor.SetActive(_isRedColor);
        _greencolor.SetActive(_isGreenColor);
        _yellowcolor.SetActive(_isYellowColor);
        _fullcolor.SetActive(_isFullColor);
        _deltacolor.SetActive(_isDeltaColor);
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {

        switch(collision.tag)
        {
            case "NoColor":
                ShowNoColorGDSC();
                break;

            case "Red":
                ShowRed();
                break;

            case "Green":
                ShowGreen();
                break;

            case "Yellow":
                ShowYellow();
                break;

            case "Full":
                ShowFullGDSC();
                break;
        }
       
       
    }

    private void ShowFullGDSC()
    {
        //if we are going down
        if (_isFullColor == true)
        {
            _isFullColor = false;
            _fullcolorAnim.SetTrigger("fadeout");
            _LaunchAnim.SetTrigger("nounderline");
            return;
        }

        //if we are going up
        _isNoColor = true;
        _isFullColor = true;
        SetSprite();
        _fullcolorAnim.SetTrigger("fadein");
        _LaunchAnim.SetTrigger("underline");
    }

    private void ShowYellow()
    {
        //if we are going down
        if (_isYellowColor == true)
        {
            _isYellowColor = false;
            _yellowcolorAnim.SetTrigger("fadeout");
            _webStrike.SetTrigger("unstrike");
            return;
        }

        //if we are going up
        _isNoColor = true;
        _isYellowColor = true;
        SetSprite();
        _yellowcolorAnim.SetTrigger("fadein");
        _webStrike.SetTrigger("strike");
    }

    private void ShowGreen()
    {
        //if we are going down
        if (_isGreenColor == true)
        {
            _isGreenColor = false;
            _greencolorAnim.SetTrigger("fadeout");
            _coreteamAnim.SetTrigger("unstrike");
            return;
        }

        //if we are going up
        _isNoColor = true;
        _isGreenColor = true;
        SetSprite();
        _greencolorAnim.SetTrigger("fadein");
        _coreteamAnim.SetTrigger("strike");
    }

    private void ShowRed()
    {
        //if we are going down
        if (_isRedColor == true)
        {
            _isRedColor = false;
            _redColorAnim.SetTrigger("fadeout");
            _domainSelectionAnim.SetTrigger("unstrike");
            return;
        }

        //if we are going up
        _isNoColor = true;
        _isRedColor = true;
        SetSprite();
        _redColorAnim.SetTrigger("fadein");
        _domainSelectionAnim.SetTrigger("strike");
    }

    private void ShowNoColorGDSC()
    {
        //if we are going down
        if (_isNoColor == true)
        {
            _isNoColor = false;
            _isDeltaColor = true;
            SetSprite();
            _leadSelectionAnim.SetTrigger("unstrike");
            return;
        }

        //if we are going up
        _isNoColor = true;
        _isDeltaColor = false;
        _leadSelectionAnim.SetTrigger("strike");
        SetSprite();
    }



}
