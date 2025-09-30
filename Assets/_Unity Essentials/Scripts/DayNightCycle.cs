using UnityEngine;

public class DayNightCycle : MonoBehaviour
{
    [Header("Directional Light (Sun)")]
    public Light directionalLight;

    [Header("Cycle Settings")]
    public float minDayDuration = 20f;
    public float maxDayDuration = 30f;

    private float dayDuration;
    private float timeOfDay = 0f;

    void Start()
    {
        dayDuration = Random.Range(minDayDuration, maxDayDuration);
    }

    void Update()
    {
        // Progress time
        timeOfDay += Time.deltaTime / dayDuration;
        if (timeOfDay >= 1f)
        {
            timeOfDay = 0f;
            dayDuration = Random.Range(minDayDuration, maxDayDuration);
        }

        // Rotate the sun (directional light)
        float sunAngle = timeOfDay * 360f - 90f;
        directionalLight.transform.rotation = Quaternion.Euler(sunAngle, 187.123f, -2.433f);

        // Optional: Adjust light intensity for night/day
        //directionalLight.intensity = Mathf.Clamp01(Mathf.Cos(timeOfDay * Mathf.PI * 2f) * 1.2f);
    }
}