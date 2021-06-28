using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Login : MonoBehaviour
{
    // Start is called before the first frame update
    public InputField EmailInput;
    public InputField PasswordInput;
    //public InputField NameInput;
    public Button LoginButton;
    //public Button CreateButton;
    void Start()
    {
        LoginButton.onClick.AddListener(() =>
        {
          StartCoroutine(Main.Instance.Web.Login(EmailInput.text, PasswordInput.text));
        });


        //CreateButton.onClick.AddListener(() =>
        //{
        //    StartCoroutine(Main.Instance.Web.RegisterUser(UsernameInput.text, PasswordInput.text, NameInput.text));
        //});


    }

    
}
