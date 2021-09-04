using UnityEngine;
using UnityEngine.UI;

public class UIStatistics : MonoBehaviour
{
    [SerializeField] private Text _moneyCount;
    [SerializeField] private Text _healthCount;

    private void Update()
    {
        _moneyCount.text = "" + Statistics._moneyCount;
        _healthCount.text = "" + Statistics._health;
    }
}
