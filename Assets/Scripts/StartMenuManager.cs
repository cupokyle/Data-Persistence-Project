using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartMenuManager : MonoBehaviour
{
    public InputField nameInputField;
    public static string playerName;

    public void StartGame()
    {
        playerName = nameInputField.text;
        SceneManager.LoadScene("main"); // Replace "MainGame" with your main game scene name
    }
}
