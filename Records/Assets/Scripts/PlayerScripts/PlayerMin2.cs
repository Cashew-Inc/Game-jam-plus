using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMini2 : MonoBehaviour
{
    private Rigidbody2D _playerRigidbody2D;
    private Animator _playerAnim;
    private SpriteRenderer _playerSprite;

    private Vector2[] positions = new Vector2[6]
    {
        new Vector2(-5, 0),
        new Vector2(-3, 0),
        new Vector2(-1, 0),
        new Vector2(1, 0),
        new Vector2(3, 0),
        new Vector2(5, 0)
    };

    private int currentPositionIndex = 2;

    void Start()
    {
        _playerRigidbody2D = GetComponent<Rigidbody2D>();
        _playerAnim = GetComponent<Animator>();
        _playerSprite = GetComponent<SpriteRenderer>();

        transform.position = positions[currentPositionIndex];
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.D))
        {
            MoveRight();
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.A))
        {
            MoveLeft();
        }
    }

    private void MoveRight()
    {
        if (currentPositionIndex < positions.Length - 1)
        {
            currentPositionIndex++;
            TeleportPlayer();
        }
    }

    private void MoveLeft()
    {
        if (currentPositionIndex > 0)
        {
            currentPositionIndex--;
            TeleportPlayer();
        }
    }

    private void TeleportPlayer()
    {
        _playerRigidbody2D.MovePosition(positions[currentPositionIndex]);

        ResetLayers();
        _playerAnim.SetLayerWeight(2, 1);

        if (currentPositionIndex > 2)
        {
            _playerSprite.flipX = false;
        }
        else if (currentPositionIndex < 2)
        {
            _playerSprite.flipX = true;
        }

        _playerAnim.SetBool("walk", true);
    }

    private void ResetLayers()
    {
        _playerAnim.SetLayerWeight(0, 0);
        _playerAnim.SetLayerWeight(1, 0);
        _playerAnim.SetLayerWeight(2, 0);
    }
}
