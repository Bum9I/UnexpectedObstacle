using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Serialization;

public class FireController : MonoBehaviour
{
    [SerializeField] private GameObject _fire;
    [SerializeField] private Transform _player;
    [SerializeField] private float _triggerDistance;
    private Vector3 _firePosition;
    private void Start()
    {
        Vector3 sumPosition = new Vector3();
        Transform torches = _fire.transform;

        int torchCount = torches.childCount;

        for (int i = 0; i < torchCount; i++)
        {
            Transform torch = torches.GetChild(i);

            sumPosition += torch.transform.position;
        }

        _firePosition = sumPosition / torchCount;
    }

    private void Update()
    {
        float distance = Vector3.Distance(_firePosition, _player.position);

        if (distance <= _triggerDistance)
        {
            _fire.SetActive(true);
            enabled = false;
        }
    }
}