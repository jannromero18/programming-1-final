using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class InputManager{

    private static GameControls _gameControls;

   public static void Init(BallController myBall){
      _gameControls = new GameControls();

      _gameControls.Start.Enable(); 

      _gameControls.Start.Begin.performed += jeff => { //look for input
          myBall.StartMovement();
       };

       _gameControls.InGame.Switch.performed += kris => { //look for input
          
       };


   }

   public static void SetStartControls(){
     _gameControls.Start.Enable();
     _gameControls.InGame.Disable();
   }

   public static void SetInGameControls(){
     _gameControls.Start.Disable();
     _gameControls.InGame.Enable();
   }
}
