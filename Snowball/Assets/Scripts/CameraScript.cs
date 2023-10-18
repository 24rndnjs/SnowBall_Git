using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public Transform PPlayer; // 플레이어를 가리키는 변수
    public float cameraSpeed = 5.0f;
    float yOffset = 2.5f;

    public GameObject player;
    Transform AT;
    void Start()
    {
        AT = player.transform;
        // 플레이어 위치로 카메라를 즉시 이동시킴
        transform.position = new Vector3(PPlayer.position.x, PPlayer.position.y + yOffset, transform.position.z);
    }
    void Update()
    {
        Vector3 targetPosition = new Vector3(PPlayer.position.x, PPlayer.position.y + yOffset, transform.position.z);
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, cameraSpeed * Time.deltaTime);
    }
}
