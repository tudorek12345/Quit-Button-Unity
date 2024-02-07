using UnityEngine;
using UnityEngine.UI;

// SCRIPT TO HANDLE THE QUIT BUTTON //
// SCRIPT TO HANDLE THE QUIT BUTTON //
// SCRIPT TO HANDLE THE QUIT BUTTON //
// SCRIPT TO HANDLE THE QUIT BUTTON //

public class QuitButton : MonoBehaviour
{
    private void Start()
    {
        // Assuming the button has an onClick event set up in the Unity Editor,
        // you can directly assign the QuitGame method to the onClick event.
        
        Button button = GetComponent<Button>();
        // will assign the QuitGame method to the onClick event
        button.onClick.AddListener(QuitGame);
    }

    private void QuitGame()
    {
        // will Quit the game
        Application.Quit();
        
// if in the Unity Editor it will stop "Play mode"

	}

}


