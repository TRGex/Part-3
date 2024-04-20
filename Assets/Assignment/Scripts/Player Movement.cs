using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{

    public float speed = 1f;
    Rigidbody player;

    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        int nextSceneIndex = (currentSceneIndex + 1) % SceneManager.sceneCountInBuildSettings;

        float directionX = Input.GetAxis("Horizontal");
        float directionY = Input.GetAxis("Vertical");
        transform.Translate(directionX * speed * Time.deltaTime, 0, 0);
        transform.Translate(0, directionY * speed * Time.deltaTime, 0);



    }
}
