using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToLobby : MonoBehaviour
{
    // Function to load the instruction scene
    public void LoadLobbyScene()
    {
        // Load the scene with the name "Instruction"
        SceneManager.LoadScene("Lobby");
    }
}
