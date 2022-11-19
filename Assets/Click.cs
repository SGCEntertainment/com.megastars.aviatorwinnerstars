using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click : MonoBehaviour
{
    public GameObject sound;
    public void click()
    {
        Instantiate(sound, transform.position, Quaternion.identity);
    }
}
