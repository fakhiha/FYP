using System.Collections;

using System.Collections.Generic;

using UnityEngine;

using TMPro;


public class OpenKeyboard : MonoBehaviour
{
    private TouchScreenKeyboard keyboard;

    public void ShowKeyboard()
    {
        keyboard = TouchScreenKeyboard.Open("", TouchScreenKeyboardType.Default);
    }
}