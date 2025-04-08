using UnityEngine;
using UnityEngine.Events;

public class GameEventListener : MonoBehaviour
{
    public GameEvent Event;
    public UnityEvent Response;
    
    public void OnEnable()
    {
        if (Event != null)
        {
            Event.RegisterListener(this);
        }
    }

    public void OnDisable()
    {
        if (Event != null)
        {
            Event.UnregisterListener(this);
        }
    }

    public void OnEventRaised()
    {
        Response.Invoke();
    }
}
