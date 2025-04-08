using UnityEngine;

[CreateAssetMenu(fileName = "BoolVariable", menuName = "Variables/BoolVariable")]
public class BoolVariable : ScriptableObject
{
    public bool Value;

    public void SetTrue()
    {
        Value = true;
    }

    public void SetFalse()
    {
        Value = false;
    }

    public void Toggle()
    {
        Value = !Value;
    }
}
