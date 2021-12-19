using System.Collections;
using System.Collections.Generic;
using TopDownShooter.PlayerInput;
using UnityEngine;

public class PlayerRotationController : MonoBehaviour
{
    [SerializeField] private InputData _inputData;
    [SerializeField] private Transform _tower;

    // Update is called once per frame
    void Update()
    {
        _tower.Rotate(0, _inputData.Horizontal, 0, Space.Self);
    }
}
