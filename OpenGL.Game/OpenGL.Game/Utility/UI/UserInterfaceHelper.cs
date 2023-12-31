﻿using OpenGL;
using OpenGL.Game;
using OpenGL.Platform;
using OpenGL.UI;
using System.Collections.Generic;

public class UserInterfaceHelper
{
    public Text topLeftText;
    public Text lightingOnText;
    public Text currentlySelectedText;
    public Text currentlySelectedTitle;
    public Text useBlinnText;

    private Game game;

    #region Pause Menu

    private bool isPauseMenuEnabled = false;
    public int ButtonWidth = 200;
    public int ButtonHeight = 75;
    public Vector4 buttonNormalColor = new Vector4(0, 0.4666666666666667f, 0.7137254901960784f, 1.0f);
    public Vector4 buttonHoverColor = new Vector4(0.011764705882352941f, 0.01568627450980392f, 0.3686274509803922f, 1.0f);
    public List<Button> pauseMenuButtons = new List<Button>();

    #endregion Pause Menu

    public bool IsUIInitalized = false;

    public void SetupUI(int width, int height, Game game)
    {
        if (IsUIInitalized) return;

        OpenGL.UI.UserInterface.InitUI(width, height);
        this.game = game;

        //Setup HUD Text

        topLeftText = new Text(Shaders.FontShader, BMFont.LoadFont("fonts/segoe_ui32.fnt"), "SAE S1", BMFont.Justification.Center);
        topLeftText.RelativeTo = Corner.TopLeft;
        topLeftText.Position = new Point(100, 50);

        lightingOnText = new Text(Shaders.FontShader, BMFont.LoadFont("fonts/segoe_ui32.fnt"), "Lighting on", BMFont.Justification.Right);
        lightingOnText.RelativeTo = Corner.TopRight;
        lightingOnText.Position = new Point(10, 50);

        currentlySelectedTitle = new Text(Shaders.FontShader, BMFont.LoadFont("fonts/segoe_ui16.fnt"), "Currently selected movement controller:", BMFont.Justification.Right);
        currentlySelectedTitle.RelativeTo = Corner.TopRight;
        currentlySelectedTitle.Position = new Point(10, 100);

        currentlySelectedText = new Text(Shaders.FontShader, BMFont.LoadFont("fonts/segoe_ui24.fnt"), "", BMFont.Justification.Right);
        currentlySelectedText.RelativeTo = Corner.TopRight;
        currentlySelectedText.Position = new Point(10, 150);

        useBlinnText = new Text(Shaders.FontShader, BMFont.LoadFont("fonts/segoe_ui24.fnt"), "Using Phong", BMFont.Justification.Right);
        useBlinnText.RelativeTo = Corner.TopRight;
        useBlinnText.Position = new Point(10, 200);

        CreatePauseMenu();
        InputHelper.ButtonEscapePressedEvent += OnEscapeChanged;

        // add all text objects to the UI
        UserInterface.AddElement(topLeftText);
        UserInterface.AddElement(lightingOnText);
        UserInterface.AddElement(currentlySelectedTitle);
        UserInterface.AddElement(currentlySelectedText);
        UserInterface.AddElement(useBlinnText);

        IsUIInitalized = true;
    }

    private void CloseApplication(object sender, MouseEventArgs e)
    {
        Window.OnClose();
    }

    public void ToggleLightingOnText(bool isOn)
    {
        if (isOn)
            lightingOnText.String = "Lighting on";
        else
            lightingOnText.String = "Lighting off";
    }

    private void CreatePauseMenu()
    {
        for (int i = 0; i < 4; i++)
        {
            int multiplier = i; //+ 1;
            int value = 50;

            if (multiplier % 2 == 0)
            {
                multiplier *= -1;
                multiplier--;
            }

            var button = new Button(ButtonWidth, ButtonHeight);
            button.RelativeTo = Corner.Center;
            button.Position = new Point(0, multiplier * value);
            button.BackgroundColor = buttonNormalColor;
            button.Font = BMFont.LoadFont("fonts/segoe_ui16.fnt");
            button.OnMouseEnter += OnMouseEnter;
            button.OnMouseLeave += OnMouseLeave;
            button.Visible = false;

            switch (i)
            {
                case 0:
                    button.OnMouseClick += CloseApplication;
                    button.Text = "Close application";
                    break;

                case 1:
                    button.OnMouseClick += (s, e) => game.ToggleDirectionalLighting();
                    button.Text = "Toggle directional lighting";
                    break;

                case 2:
                    button.OnMouseClick += (s, e) => game.ToggleBlinnLighting();
                    button.Text = "Toggle blinn lighting";
                    break;

                case 3:
                    button.OnMouseClick += MakeNextSceneActive;
                    button.Text = "Go to next scene";
                    break;
            }

            UserInterface.AddElement(button);
            pauseMenuButtons.Add(button);
        }
    }

    private void MakeNextSceneActive(object sender, MouseEventArgs e)
    {
        game.MakeNextSceneActive();
    }

    private void OnMouseLeave(object sender, MouseEventArgs e)
    {
        var button = sender as Button;
        button.BackgroundColor = buttonNormalColor;
    }

    private void OnMouseEnter(object sender, MouseEventArgs e)
    {
        var button = (Button)sender;
        button.BackgroundColor = buttonHoverColor;
    }

    private void TogglePauseMenu(bool isOn)
    {
        foreach (var button in pauseMenuButtons)
        {
            button.Visible = isOn;
        }
    }

    private void OnEscapeChanged(bool isPressed)
    {
        if (!isPressed) return;

        isPauseMenuEnabled = !isPauseMenuEnabled;
        TogglePauseMenu(isPauseMenuEnabled);
    }
}