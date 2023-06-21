using UnityEngine;

public class BridgeController : MonoBehaviour
{
    [SerializeField] private GameObject _bridge;
    [SerializeField] private Transform _player; 
    [SerializeField] private float _triggerDistance = 5f;

    private void Update()
    {
        float distance = Vector3.Distance(_bridge.transform.position, _player.position);

        if (_player.GetComponent<Outline>().OutlineWidth == 2f)
        {
            enabled = false;
        }
        else if (distance <= _triggerDistance)
        {
            _bridge.GetComponent<Bridge>().Break();
            enabled = false;
        }
    }
}