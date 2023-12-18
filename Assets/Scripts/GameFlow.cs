using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;
using UnityEngine.InputSystem.LowLevel;

public class GameFlow : MonoBehaviour
{
    [SerializeField] Transform player;
    ButtonControl startButton;
    [SerializeField] UnityEvent endFightingPhaseEvent;
    [SerializeField] UnityEvent startFightingPhaseEvent;
    [SerializeField] Enemies enemies;

    private void Awake()
    {
        //startButton = Gamepad.current[GamepadButton.Start];
    }

    // Update is called once per frame
    void Update()
    {
        if (Enemies.endPhase)
        {
            print("End Phase");
            endFightingPhaseEvent.Invoke();
        }
        if(Enemies.endPhase && startButton.isPressed)
        {
            startFightingPhaseEvent.Invoke();
        }
    }
}
