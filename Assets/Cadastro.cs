using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cadastro : MonoBehaviour
{
    // Start is called before the first frame update
    public InputField InsertEmail; // email
    public InputField InsertPassword; // senha
    public InputField InsertName; // nome
    //public Button LoginButton;
    public Button CreateAccount;
    void Start()
    {
        //LoginButton.onClick.AddListener(() =>
        //{
        //    StartCoroutine(Main.Instance.Web.Login(UsernameInput.text, PasswordInput.text));
        //});


        CreateAccount.onClick.AddListener(() =>
        {
            StartCoroutine(Main.Instance.Web.RegisterUser(InsertEmail.text, InsertPassword.text, InsertName.text));
        });


    }


}
