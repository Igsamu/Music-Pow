using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeadBee : MonoBehaviour
{
    public PlayerMove playerMove;
    public Animator animator;
    public Animator animator2;
    public Animator animator3;

    private void Start()
    {
        playerMove = FindObjectOfType<PlayerMove>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            playerMove.enabled = false;
            animator.Play("FadeInGameOver");
            animator2.Play("FadeInGameOverL");
            animator3.Play("AudioOut");
            Invoke("GameOut", 3);
        }
    }

    private void GameOut()
    {
        SceneManager.LoadScene("Menu");
    }
}
