using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public Transform PPlayer; // �÷��̾ ����Ű�� ����
    public float cameraSpeed = 5.0f;
    float yOffset = 2.5f;

    public GameObject player;
    Transform AT;
    void Start()
    {
        AT = player.transform;
        // �÷��̾� ��ġ�� ī�޶� ��� �̵���Ŵ
        transform.position = new Vector3(PPlayer.position.x, PPlayer.position.y + yOffset, transform.position.z);
    }
    void Update()
    {
        Vector3 targetPosition = new Vector3(PPlayer.position.x, PPlayer.position.y + yOffset, transform.position.z);
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, cameraSpeed * Time.deltaTime);
    }
}
