using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Globalization;

public class InputSetter : MonoBehaviour
{
    [SerializeField] private Emitter _emitter;
    [SerializeField] private TMP_InputField _distanceInput;
    [SerializeField] private TMP_InputField _speedInput;
    [SerializeField] private TMP_InputField _cooldownInput;

    public void ApllyDistance()
    {
        if (string.IsNullOrEmpty(_distanceInput.text)) return;
        _emitter.CubeDistance = float.Parse(_distanceInput.text, CultureInfo.InvariantCulture);
    }

    public void ApplySpeed()
    {
        if (string.IsNullOrEmpty(_speedInput.text)) return;
        _emitter.CubeSpeed = float.Parse(_speedInput.text, CultureInfo.InvariantCulture);
    }

    public void ApllyCooldown()
    {
        if (string.IsNullOrEmpty(_cooldownInput.text)) return;
        _emitter.CubeFireCooldown = float.Parse(_cooldownInput.text, CultureInfo.InvariantCulture);
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void ResetScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
