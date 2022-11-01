using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionAutoDestroyer : MonoBehaviour
{
    [SerializeField]
    private StageData stageData;
    private float destoroyWeight = 2.0f;

    private void LateUpdate()
    {
        if( transform.position.y < stageData.LimitMin.y - destoroyWeight ||
            transform.position.y > stageData.LimitMax.y + destoroyWeight ||
            transform.position.x < stageData.LimitMin.x - destoroyWeight ||
            transform.position.x > stageData.LimitMax.x + destoroyWeight )
        {
            Destroy(gameObject);
        }
    }
}
