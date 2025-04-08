using System.Collections.Generic;
using UnityEngine;

public class NemanjasMechResetter : MonoBehaviour
{
    [SerializeField]
    private StringVariable infoText;

    [SerializeField]
    private FloatVariable statsNumber;

    [SerializeField]
    private GameEvent gravityEnabled;

    [SerializeField]
    private List<NemanjasMech> fallingMechs;

    private void Update()
    {
        if (fallingMechs.Count == statsNumber.Value)
        {
            ResetFallingMechPositions();
        }
    }

    private void ResetFallingMechPositions()
    {
        foreach (var mech in fallingMechs)
        {
            mech.ResetPosition();
        }
        infoText.Value = "";
        statsNumber.Value = 0;
    }
}
