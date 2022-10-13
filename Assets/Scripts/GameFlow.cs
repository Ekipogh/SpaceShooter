using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;
using UnityEngine.InputSystem.LowLevel;
using UnityEngine.SceneManagement;

public class GameFlow : MonoBehaviour
{
    [SerializeField] Transform player;
    ButtonControl startButton;

    private void Awake()
    {
        startButton = Gamepad.current[GamepadButton.Start];
        DontDestroyOnLoad(this);
        DontDestroyOnLoad(player.gameObject);
    }
    // Update is called once per frame
    void Update()
    {
        if (startButton.isPressed)
        {
            SceneManager.LoadScene(sceneName: "BuildScene");
        }
    }
}
