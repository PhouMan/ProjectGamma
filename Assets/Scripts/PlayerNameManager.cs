using UnityEngine;
using TMPro;
public class PlayerNameManager : MonoBehaviour
{
    public TMP_InputField inputField; // Reference to the Input Field
    private string username;          // Variable to store the username

    void Start()
    {
        // Optionally set a default username
        username = "Guest";
    }

    // Method to be called when the user presses Enter
    public void SaveUsername(string input)
    {
        username = input; // Save the input as the username
        Debug.Log("Player name saved: " + username);

        // Optionally clear the input field after saving
        inputField.text = "";
    }
}
