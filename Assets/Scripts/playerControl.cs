using UnityEngine;
using UnityEngine.AI;

public class playerControl : MonoBehaviour
{
    [SerializeField] NavMeshAgent navAgent;
    [SerializeField] Animator animator;
    public Transform playerTrans{get{return transform;}}
    
    public void OnClickMapPos(Vector3 pos)
    {
        navAgent.destination = pos;
    }
    void Update()
    {
        animator.SetFloat("sqrSpeed", navAgent.velocity.sqrMagnitude);
    }
}