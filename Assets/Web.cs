using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

public class Web : MonoBehaviour
{
    void Start()
    {
        //StartCoroutine(GetUsers());
        //StartCoroutine(Login("test@tutanota.com", "1234"));
        //StartCoroutine(RegisterUser("rubens@tutanota.com", "1234", "Rubens"));
    }

   public IEnumerator GetUsers()
    {
        using (UnityWebRequest www = UnityWebRequest.Get("http://localhost/unitybackend/GetUsers.php")){
        yield return www.Send();

        if (www.isNetworkError || www.isHttpError)
        {
            Debug.Log(www.error);
        }
        else
        {
            // Show results as text
            Debug.Log(www.downloadHandler.text);

            // Or retrieve results as binary data
            byte[] results = www.downloadHandler.data;
        }

        }
       
    }


    public IEnumerator Login(string email, string password)
    {
        WWWForm form = new WWWForm();
        form.AddField("logiUser", email);
        form.AddField("logiPass", password);


        using (UnityWebRequest www = UnityWebRequest.Post("http://localhost/unitybackend/Login.php", form))
        {
            yield return www.SendWebRequest();

            if (www.isNetworkError || www.isHttpError)
            {
                Debug.Log(www.error);
            }
            else
            {
                Debug.Log(www.downloadHandler.text);
            }
        }
    }



     public IEnumerator RegisterUser(string email, string password, string username)
    {
        WWWForm form = new WWWForm();
        form.AddField("logiUser", email);
        form.AddField("logiPass", password);
        form.AddField("logiName", username);



        using (UnityWebRequest www = UnityWebRequest.Post("http://localhost/unitybackend/RegisterUser.php", form))
        {
            yield return www.SendWebRequest();

            if (www.isNetworkError || www.isHttpError)
            {
                Debug.Log(www.error);
            }
            else
            {
                Debug.Log(www.downloadHandler.text);
            }
        }
    }
}

