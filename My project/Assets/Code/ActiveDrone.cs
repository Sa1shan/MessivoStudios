using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveDrone : MonoBehaviour
{
    public GameObject objectToDisable;
    public string playerTag = "Player";

    private void OnMouseDown()
    {
        objectToDisable.SetActive(false);

        // Найти объект с тегом "Player" и включить его
        GameObject player = GameObject.FindGameObjectWithTag(playerTag);
        if (player != null)
        {
            player.SetActive(true);
        }
    }

    private void Update()
    {
        // Если объект с тегом "Player" активен, управлять им с помощью WASD
        GameObject player = GameObject.FindGameObjectWithTag(playerTag);
        if (player != null && player.activeSelf)
        {
            float horizontalInput = Input.GetAxis("Horizontal");
            float verticalInput = Input.GetAxis("Vertical");

            player.transform.Translate(new Vector3(horizontalInput, verticalInput, 0) * Time.deltaTime * 1.0f);
        }
    }
}
