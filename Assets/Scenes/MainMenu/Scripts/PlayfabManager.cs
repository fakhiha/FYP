using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PlayFab;
using PlayFab.ClientModels;
using Newtonsoft.Json;
using UnityEngine.UI;
using TMPro;

public class PlayfabManager : MonoBehaviour
{
    //public GameObject Panel;
    [SerializeField] private GameObject newPanel;
    [Header("UI")]
    public TMP_Text messageText;
    public TMP_InputField emailInput;
    public TMP_InputField passwordInput;
    public TMP_InputField nameInput;

    public void RegisterButton()
    {
        
        if(passwordInput.text.Length <6)
        {
            messageText.text = "Password too short!";
            return;
        }
        var request = new RegisterPlayFabUserRequest
        {
            DisplayName = nameInput.text,
            Email = emailInput.text,
            Password = passwordInput.text,
            RequireBothUsernameAndEmail = false
        };
        PlayFabClientAPI.RegisterPlayFabUser(request, OnRegisterSuccess, OnError);
    }

    void OnRegisterSuccess(RegisterPlayFabUserResult result)
    {
       // messageText.text = "Registration Successful";
        // Disable the current panel
        gameObject.SetActive(false);

        // Enable the new panel
        newPanel.SetActive(true);
    }

    /*public void LoginButton()
    {
        var request = new LoginWithEmailAddressRequest
        {
            Email= emailInput.text,
            Password = passwordInput.text
        };
        PlayFabClientAPI.LoginWithEmailAddress(request, OnLoginSuccess, OnError);

    }*/

    public void ResetPasswordButton()
    {

    }

    void OnPasswordReset(SendAccountRecoveryEmailResult result)
    {

    }

    /*void OnLoginSuccess(LoginResult result)
    {
        messageText.text = "Logged In!";
        Debug.Log("Successful login/account create");
        // Disable the current panel
        //gameObject.SetActive(false);

        // Enable the new panel
        //newPanel.SetActive(true);

    }*/

   
    void OnError(PlayFabError error)
    {
        messageText.text = error.ErrorMessage;
        Debug.Log(error.GenerateErrorReport());
        
    }
}
