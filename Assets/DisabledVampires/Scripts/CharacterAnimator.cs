using UnityEngine;

[RequireComponent(typeof(Animator))]

public class CharacterAnimator : MonoBehaviour
{
    [SerializeField] private Animator _animator;
    [SerializeField] private CharacterMove _characterMove;
    [SerializeField] private SpriteRenderer _spriteRenderer;

    private const string X_Hash = "X";
    private const string Y_Hash = "Y";

    private void Awake() => 
        _spriteRenderer.flipY = false;

    private void FixedUpdate() => 
        ToMoveAnimate(_characterMove.Move);

    private void ToMoveAnimate(Vector2 moveVector)
    {
        _animator.SetFloat(X_Hash, moveVector.x);
        _animator.SetFloat(Y_Hash, moveVector.y);

        Flip(moveVector);
    }

    private void Flip(Vector2 moveVector)
    {
        if (moveVector.x > 0)
            _spriteRenderer.flipX = true;
        else
            _spriteRenderer.flipX = false;
    }
}
