using UnityEngine;

public class CharacterMove : MonoBehaviour
{
    [SerializeField] private float _speed = 2;

    public Vector2 Move { get; private set; }

    private void FixedUpdate()
    {
        ToMove();
    }

    private void ToMove()
    {
        Move = new(SimpleInput.GetAxis("Horizontal"), SimpleInput.GetAxis("Vertical"));
        transform.position += new Vector3(Move.x, Move.y, 0) * _speed / 10;
    }
}
