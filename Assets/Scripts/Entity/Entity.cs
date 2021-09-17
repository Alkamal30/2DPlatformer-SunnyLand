using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;


namespace SunnyLandGame {
    public class Entity : MonoBehaviour {
        
        [SerializeField] private EntityMovement _entityMovement = null;
        [SerializeField] private EntityAnimator _entityAnimator = null;


        public EntityMovement Movement => _entityMovement;
        public EntityAnimator Animator => _entityAnimator;


    }
}
