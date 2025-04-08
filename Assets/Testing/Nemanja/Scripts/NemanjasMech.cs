using UnityEngine;

public class NemanjasMech : MonoBehaviour
{
    [SerializeField]
    private GameObject ground;

    [SerializeField]
    private GameEvent playerHitGround;

    [SerializeField]
    private FloatVariable statsNumber;

    [SerializeField]
    private StringVariable infoText;

    private Vector3 startPosition;

    private void Start()
    {
        startPosition = transform.position;
        statsNumber.Value = 0;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject == ground) {
            gameObject.GetComponent<Rigidbody>().useGravity = false;
            statsNumber.Value += 1;
            infoText.Value = gameObject.name;
            playerHitGround.Raise();
        }
    }

    public void ResetPosition()
    {
        transform.position = startPosition;
    }   

    public void EnableGravity()
    {
        gameObject.GetComponent<Rigidbody>().useGravity = true;
    }
}
