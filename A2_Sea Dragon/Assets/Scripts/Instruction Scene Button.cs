using UnityEngine;
using UnityEngine.SceneManagement;

public class InstructionSceneButton : MonoBehaviour
{
    // Function to load the instruction scene
    public void LoadInstructionScene()
    {
        // Load the scene with the name "Instruction"
        SceneManager.LoadScene("Instruction");
    }
}
