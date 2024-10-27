using UnityEngine;
using TMPro;

public class UserNameInputHandler : MonoBehaviour
{
    private TMP_InputField userNameInputField;
    private UserName userName;
    [SerializeField] GameObject lobbyBack;
    [SerializeField] GameObject InputFieldUI;

    public void OnSubmit()
    {
        userName = Resources.Load<UserName>("UserName");
        userNameInputField = GetComponent<TMP_InputField>();
        userName.Name = userNameInputField.text;
        Debug.Log("User Name saved: " + userName.Name);
    }

    public void onDone()
    {
        InputFieldUI.SetActive(false);
        lobbyBack.SetActive(true);
    }
}
