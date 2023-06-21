using UnityEngine;
using UnityEngine.Serialization;

public class ChestController : MonoBehaviour
{
    [SerializeField] private GameObject _chest;
    [SerializeField] private Transform _player; 
    [SerializeField] private float _triggerDistance;

    private void Update()
    {
        float distance = Vector3.Distance(_chest.transform.position, _player.position);

        if (distance <= _triggerDistance)
        {
            _chest.GetComponent<Chest>().Open();
            enabled = false;
        }
    }
}