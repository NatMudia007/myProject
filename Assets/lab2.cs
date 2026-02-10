using UnityEngine;

/// UNITY BASICS – CORE UNITY CONCEPTS
/// Attach this script to ONE GameObject
/// Uncomment ONE section at a time

public class UnityCoreConceptsWorksheet : MonoBehaviour
{
    void Start()
    {
        // Section1_GameObjects();
        // Section2_Components();
        // Section3_ActiveState();
        // Section4_FindObjects();
        // Section5_Time();
        // Section6_Physics();
    }


    // ===== SECTION 1: GAMEOBJECT =====
    void Section1_GameObjects()
    {
        Debug.Log("Player2: " + gameObject.name);
        Debug.Log("Player: " + gameObject.tag);

        // TASKS:
        // 1. Rename this GameObject to "Player"
        // 2. Set its tag to "Player"
        // 3. Console should print:
        //    Name: Player
        //    Tag: Player
    }


    // ===== SECTION 2: COMPONENTS =====
    void Section2_Components()
    {
        Transform t = GetComponent<Transform>();
        Debug.Log("Position: " + t.position);

        Rigidbody rb = GetComponent<Rigidbody>();

        if (rb != null)
        {
            Debug.Log("Rigidbody mass: 2 " + rb.mass);
        }

        // TASKS:
        // 1. Add a Rigidbody component
        // 2. Set Mass to 2
        // 3. Console should print:
        //    Rigidbody mass: 2
    }


    // ===== SECTION 3: ACTIVE STATE =====
    void Section3_ActiveState()
    {
        Debug.Log("Active: " + gameObject.activeSelf);

         gameObject.SetActive(false);

        // TASKS:
        // 1. Uncomment SetActive(false)
        // 2. Press Play
        // 3. GameObject disappears from the Scene
    }


    // ===== SECTION 4: FINDING OBJECTS =====
    void Section4_FindObjects()
    {
        GameObject enemy = GameObject.Find("Enemy1");

        if (enemy != null)
        {
            Debug.Log("Enemy1 found");
        }

        // TASKS:
        // 1. Create a GameObject named "Enemy"
        // 2. Press Play
        // 3. Console should print:
        //    Enemy found
    }


    // ===== SECTION 5: TIME =====
    void Section5_Time()
    {
        Debug.Log("Time: " + Time.time);

        transform.Translate(Vector3.right * Time.deltaTime);

        // TASKS:
        // 1. Press Play
        // 2. Object moves slowly to the right
        // 3. Movement is smooth (not jumping)
    }


    // ===== SECTION 6: PHYSICS =====
    void Section6_Physics()
    {
        Rigidbody rb = GetComponent<Rigidbody>();

        if (rb != null)
        {
            rb.AddForce(Vector3.up * 5f, ForceMode.Impulse);
        }

        // TASKS:
        // 1. Add Rigidbody
        // 2. Enable Gravity
        // 3. Press Play
        // 4. Object jumps upward once
    }
}