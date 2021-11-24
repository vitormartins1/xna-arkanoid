using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;

namespace Arkanoid
{
    
    static public class SceneManager
    {
        static private SCENE currentScene;
        static public Scene scene = null;

        static private Random random = new Random();
            
        static public void Setup(Game game)
        {
            SceneManager.scene = new Opening(game);
            game.Components.Add(SceneManager.scene);
            SceneManager.currentScene = SCENE.SCN_OPENING;
        }

        static public void ChangeScene(Game game)
        {
            game.Components.Clear();

            switch (SceneManager.currentScene)
            {
                case SCENE.SCN_OPENING:                    
                    SceneManager.scene = new Level01(game);
                    SceneManager.currentScene = SCENE.SCN_LEVEL_01;
                    break;

                case SCENE.SCN_LEVEL_01:

                    SceneManager.scene = new Level02(game);
                    SceneManager.currentScene = SCENE.SCN_LEVEL_02;

                    break;
                case SCENE.SCN_LEVEL_02:

                    SceneManager.scene = new Level03(game);
                    SceneManager.currentScene = SCENE.SCN_LEVEL_03;

                    break;

                case SCENE.SCN_LEVEL_03:

                    SceneManager.scene = new Level04(game);
                    SceneManager.currentScene = SCENE.SCN_LEVEL_04;

                    break;

                case SCENE.SCN_LEVEL_04:

                    SceneManager.scene = new Level05(game);
                    SceneManager.currentScene = SCENE.SCN_LEVEL_05;

                    break;

                case SCENE.SCN_LEVEL_05:

                    SceneManager.scene = new Level06(game);
                    SceneManager.currentScene = SCENE.SCN_LEVEL_06;

                    break;

                case SCENE.SCN_LEVEL_06:

                    SceneManager.scene = new Congrats(game);
                    SceneManager.currentScene = SCENE.SCN_CONGRATS;

                    break;

                case SCENE.SCN_CONGRATS:
                    SceneManager.scene = new Opening(game);
                    SceneManager.currentScene = SCENE.SCN_OPENING;
                    break;

                case SCENE.SCN_GAMEOVER:                    
                    SceneManager.scene = new Opening(game);
                    SceneManager.currentScene = SCENE.SCN_OPENING;
                    break;

                default:
                    SceneManager.scene = new Opening(game);
                    SceneManager.currentScene = SCENE.SCN_OPENING;
                    Console.WriteLine("SCENEMANAGER: OCORREU UM ERRO");
                    break;
            }

            game.Components.Add(SceneManager.scene);
        }
    }

    public enum SCENE
    {
        SCN_OPENING,
        SCN_LEVEL_01,
        SCN_LEVEL_02,
        SCN_LEVEL_03,
        SCN_LEVEL_04,
        SCN_LEVEL_05,
        SCN_LEVEL_06,
        SCN_CONGRATS,
        SCN_GAMEOVER
    }
}
