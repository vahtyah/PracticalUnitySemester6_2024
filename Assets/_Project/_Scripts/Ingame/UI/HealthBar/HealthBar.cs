using Practical.Practical_7.Scripts;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private Slider slider;
    [SerializeField] private SpiderController spider;

    private Camera camera;

    private void Awake()
    {
        camera = Camera.main;
        spider.onChangeHealth += UpdateHealthBar;
    }

    private void OnEnable()
    {
        slider.gameObject.SetActive(false);
    }

    private void UpdateHealthBar(float healthNormalized)
    {
        slider.value = healthNormalized;
        if(slider.value <= 0)
        {
            slider.gameObject.SetActive(false);
            spider.onChangeHealth -= UpdateHealthBar;
            return;
        }
        if(!slider.gameObject.activeSelf) slider.gameObject.SetActive(true);
    }

    private void LateUpdate()
    {
        if (camera != null) transform.LookAt(transform.position + camera.transform.forward);
    }
}