using UnityEngine;

public class BaseCharacter : MonoBehaviour
{
    [Header("Character Stats")]
    [SerializeField] private int health = 100;
    [SerializeField] private int speed;
    [SerializeField] private float reactionTime;
    [SerializeField] private float painChance;
    [SerializeField] private float painTime;
    [SerializeField] private int mass;
    [SerializeField] private bool isDead;

    private void Start()
    {
        
    }
    private void Update()
    {
        
    }
    private void CalculateHealth()
    {
        return;
    }
    private void CalculateDeath()
    {
        return;
    }
    private void SpawnCorpse()
    {
        return;
    }
    private void CalculatePain()
    {
        return;
    }
    private void SpawnPickup()
    {
        return;
    }
}
