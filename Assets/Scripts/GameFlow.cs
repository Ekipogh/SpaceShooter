using UnityEngine;
using UnityEngine.Events;

public class GameFlow : MonoBehaviour
{
    [SerializeField] Transform player;
    //ButtonControl startButton;
    [SerializeField] UnityEvent endFightingPhaseEvent;
    [SerializeField] Enemies enemies;

    private void Awake()
    {
        //startButton = Gamepad.current[GamepadButton.Start];
        //DontDestroyOnLoad(this);
        //DontDestroyOnLoad(player.gameObject);
    }
    // Update is called once per frame
    void Update()
    {
        if (Enemies.endPhase)
        {
            print("End Phase");
            endFightingPhaseEvent.Invoke();
        }
    }
}
