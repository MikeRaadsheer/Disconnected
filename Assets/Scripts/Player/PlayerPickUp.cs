using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPickUp : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<PickUp>())
        {
            PickUp pickUp = other.gameObject.GetComponent<PickUp>();

            pickUp.Run();
        }
    }
}

            //PlayerEffect effect = other.GetComponent<PlayerEffect>().GetEffect();

            //ApplyEffect(effect.type, effect.modifierAmount, effect.duration);
            //Destroy(other.gameObject);




//}
//        if (_buffDeactivation > 0)
//        {
//            _buffDeactivation -= Time.fixedDeltaTime;
//        }

//        if (_isBuffed && _buffDeactivation <= 0)
//        {
//            if (IsBuffed != null)
//            {
//                IsBuffed(false, EffectType.NONE);
//            }
//            UnityEngine.Debug.Log("Deactivate Buff");
//            _moveSpeed = _defaultMoveSpeed;
//            _isBuffed = false;
//        }



//private float _buffDeactivation;
//private bool _isBuffed = false;

//private void ApplyEffect(EffectType type, float amount, float duration)
//{
//    if (IsBuffed != null)
//    {
//        IsBuffed(true, type);
//    }

//    _isBuffed = true;

//    _buffDeactivation = duration;

//    switch (type)
//    {
//        case EffectType.SPEED:
//            _jumpHeight = _defaultJumpHeight;
//            _moveSpeed = _defaultMoveSpeed * amount;
//            break;
//        case EffectType.JUMP_HEIGHT:
//            _moveSpeed = _defaultMoveSpeed;
//            _jumpHeight = _defaultJumpHeight * amount;
//            break;
//    }

//}