using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering.LWRP;
using UnityEngine.Experimental.Rendering.Universal;
//using Light2D = UnityEngine.Experimental.Rendering.LWRP.Light2D;

public class LightCondition : MonoBehaviour
{
    // Start is called before the first frame update

    public CircleCollider2D player;
    public CircleCollider2D lamp;
    public UnityEngine.Experimental.Rendering.Universal.Light2D light;

    [SerializeField] GameObject _gameState;

    [SerializeField] GameObject _player;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Light") && player.IsTouching(lamp) == true)
        {
            light.enabled = true;
        }

        /*  else if (Input.GetButtonDown("Light") && player.IsTouching(lamp) == false) {
              light.enabled = false;
          }
          else if (Input.GetButtonDown("Light") && player.IsTouching(lamp) == false)
          {

          }*/

        if (Input.GetButtonDown("Light") && player.IsTouching(lamp) == true && lamp.enabled == true)
        {
            GameStates.Instance.IncreaseScore(1);
            lamp.enabled = false;
        }
    }

    /*void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.name == _player.name && Input.GetButtonDown("Light") && player.IsTouching(lamp) == true && lamp.enabled == true)
        {
            GameStates.Instance.IncreaseScore(1);
            lamp.enabled = false;
        }
    }*/




}
