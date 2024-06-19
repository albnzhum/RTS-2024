using UnityEngine;
using UnityEngine.AI;

public class UnitController : MonoBehaviour
{
    private NavMeshAgent agent;

    private void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    /// <summary>
    /// Перемещает юнита к заданной точке назначения.
    /// </summary>
    /// <param name="destination">Точка назначения.</param>
    public void MoveTo(Vector3 destination)
    {
        agent.SetDestination(destination);
    }

    /// <summary>
    /// Атакует цель, окружая её.
    /// </summary>
    /// <param name="target">Цель для атаки.</param>
    public void AttackTarget(Transform target)
    {
        Vector3 direction = (target.position - transform.position).normalized;
        Vector3 destination = target.position - direction * 1.5f; // Позиция вокруг цели
        MoveTo(destination);
    }
}
