using System.Threading;
using TMPro;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;
using UnityEngine.UI;

public class Spin : MonoBehaviour
{
    [SerializeField] private Image Timer;
    [SerializeField] private float One = 3f;
    [SerializeField] private TMP_Text NadoBiloNaGitHubZagrujatb3;
    private float timerPressedButton = 0f;
    private bool pressButton = false;

    public int Counter = 0;

    private void FixedUpdate()
    {
        if (pressButton)
        {
            timerPressedButton += Time.deltaTime;
            Timer.fillAmount = timerPressedButton / One;
            if (timerPressedButton > One)
            {
                timerPressedButton = 0f;
                pressButton = false;

                Counter++;
                NadoBiloNaGitHubZagrujatb3.text = Counter.ToString();
            }
        }
    }

    public void Atom()
    {
        pressButton = true;
    }
}
