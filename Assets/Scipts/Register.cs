using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Register : MonoBehaviour
{

    public InputField username;
    public InputField password;
    public InputField rePassword;

    public Button register;

    public void CallRegister()
    {
        StartCoroutine(registerFunc());
    }
    IEnumerator registerFunc()
    {
        WWWForm form = new WWWForm();
        form.AddField("username", username.text);
        form.AddField("password", password.text);
        form.AddField("rePassword", rePassword.text);
        WWW www = new WWW("http://localhost/sqlConnect/users.php", form);
        yield return www;
        Debug.Log(www.text);
        if (www.text == "0")
        {
            Debug.Log("logiin success");
        }
        else
        {
            Debug.Log("login fail");
        }
    }

    // Update is called once per frame
    void Update()
    {
    }
}
