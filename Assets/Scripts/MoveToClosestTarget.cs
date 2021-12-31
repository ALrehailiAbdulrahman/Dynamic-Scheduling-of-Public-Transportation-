using UnityEngine;
using UnityEngine.AI;

public class MoveToClosestTarget : MonoBehaviour
{
    public Transform[] Targets;
    public NavMeshAgent Agent;


    private void Start()
    {
        ChooseTarget();
    }
    public void ChooseTarget()
    {
        float closestTargetDistance = float.MaxValue;
        NavMeshPath Path = null;
        NavMeshPath ShortestPath = null;

        for (int i = 0; i < Targets.Length; i++)
        {
            
            Path = new NavMeshPath();

           
                float distance = Vector3.Distance(transform.position, Path.corners[0]);
            Debug.Log(distance);
            for (int j = 1; j < Path.corners.Length; j++)
                {
                    distance += Vector3.Distance(Path.corners[j - 1], Path.corners[j]);
                }
                Debug.Log(distance);

                if (distance < closestTargetDistance)
                {
                    closestTargetDistance = distance;
                    ShortestPath = Path;
                }
            
        }

        if (ShortestPath != null)
        {
            Agent.SetPath(ShortestPath);
        }
    }

  
}