using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMini1 : MonoBehaviour
{
    public float _playerMiniSpeed;
    private Rigidbody2D _playerRigidbody2D;
    private Vector2 _playerDirection;
    private Animator _playerAnim;
    private SpriteRenderer _playerSprite;
    // Start is called before the first frame update

    void Start()
    {
        _playerRigidbody2D = GetComponent<Rigidbody2D>();
        _playerAnim = GetComponent<Animator>();
        _playerSprite = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        MoveOn();
    }

    private void ResetLayers()
    {
        _playerAnim.SetLayerWeight(0, 0);
        _playerAnim.SetLayerWeight(1, 0);
        _playerAnim.SetLayerWeight(2, 0);
    }

    private void MoveOn()
    {
        _playerDirection = new Vector2(Input.GetAxisRaw("Horizontal"), 0);
        _playerRigidbody2D.MovePosition(_playerRigidbody2D.position + _playerDirection * _playerMiniSpeed * Time.fixedDeltaTime);

        if (_playerDirection.x != 0)
        {
            ResetLayers();
            _playerAnim.SetLayerWeight(2, 1);

            if (_playerDirection.x > 0)
            {
                _playerSprite.flipX = false;
            }
            else if (_playerDirection.x < 0)
            {
                _playerSprite.flipX = true;
            }

        }

        if (_playerDirection != Vector2.zero)
        {
            _playerAnim.SetBool("walk", true);
        }
        else
        {
            _playerAnim.SetBool("walk", false);
        }
    }
}
