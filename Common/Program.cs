﻿


namespace SprtaaaaDungeon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.CursorVisible = false;

            GameManager.Instance.StartGame();

            var sceneController = GameManager.Instance.SceneController;


            while (true)
            {
                sceneController.UpdateScene();
            }
        }
    }
}
