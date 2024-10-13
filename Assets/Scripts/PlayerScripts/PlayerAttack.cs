using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Assets.Scripts.PlayerScripts.Support;
using NUnit.Framework.Internal;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public List<GameObject> AttackTemplates;
    public float AttackCooldown = 2;

    private GameObject player;




    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(AttackOnCooldown());
    }

    private static Vector3 GetCursorPositionInWorld()
    {
        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        Physics.Raycast(ray, out var hit);
        var hitPosition = new Vector3(hit.point.x, 1, hit.point.z);
        return hitPosition;
    }

    IEnumerator AttackOnCooldown()
    {
        while (true)
        {
            var hitPosition = GetCursorPositionInWorld();

            foreach (var attackTemplate in AttackTemplates)
            {
                if (attackTemplate != null) attackTemplate.GetComponent<AttackTemplate>().Attack(player, hitPosition);
            }

            yield return new WaitForSeconds(AttackCooldown);
        }
    }
}

