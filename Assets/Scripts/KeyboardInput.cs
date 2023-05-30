using UnityEngine;
using UnityEngine.UI;

public class KeyboardInput : MonoBehaviour
{
    private TouchScreenKeyboard keyboard;

    public void ShowKeyboard()
    {
        keyboard = TouchScreenKeyboard.Open("", TouchScreenKeyboardType.Default);
    }
}
