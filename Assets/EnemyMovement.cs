using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enem : MonoBehaviour
{
    private GameplayManager gameplayManager;
    private Vector3 moveDir;
    private Transform _model;
    private Rigidbody _rb;
    [SerializeField] private float speed;
    [SerializeField] private float hungerPoint;
    [SerializeField] private int scoreIndex;

    private void Awake()
    {
        _model = GetComponent<Transform>();
        _rb = GetComponent<Rigidbody>();
        gameplayManager = FindObjectOfType<GameplayManager>();
    }
    private void Start()
    {
        transform.Rotate(Vector3.up, 180f);
        MoveEnemy();
    }

    void MoveEnemy()
    {
        moveDir = new Vector3(0f, 0f, -speed * Time.deltaTime).normalized;

        Vector3 velocity = moveDir * speed;
        _rb.velocity = velocity;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            gameplayManager.addScore(scoreIndex);
            Destroy(gameObject);
        }
        if (other.CompareTag("Border"))
        {
            Destroy(gameObject);
        }
    }
}
