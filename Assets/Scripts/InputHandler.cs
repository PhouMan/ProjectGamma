using UnityEngine;
using TMPro;  // Only needed if you're using TextMeshPro

public class InputHandler : MonoBehaviour
{
    public TMP_InputField inputField; // Use TMP_InputField if using TextMeshPro, or InputField otherwise

    public void PrintInputText()
    {
        string userInput = inputField.text;
        Debug.Log("User Input: " + userInput);
    }
}


