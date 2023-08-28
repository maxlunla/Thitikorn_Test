using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    private static readonly int Idle = Animator.StringToHash("Idle");
    private static readonly int Walk = Animator.StringToHash("Walk");
    private static readonly int Attack = Animator.StringToHash("Attack");
    private static readonly int Die = Animator.StringToHash("Die");

    // Component
    private Animator m_Anim;
    private NavMeshAgent m_Agent;

    // Enemy
    private Transform m_Target;

	// Status
	private int MaxHP = 100;
	private int Atk = 10;

	void Start()
    {
        m_Anim = GetComponent<Animator>();
        m_Agent = GetComponent<NavMeshAgent>();
    }
	void Update()
	{
        if (MaxHP <= 0)
        {
            m_Anim.Play(Die);
        }

		if (MaxHP < 100)
        {

        }
	}

    public void DecreaseHP(int Damage)
    {
        MaxHP = MaxHP - Damage;
        Debug.Log(MaxHP);
    }
}