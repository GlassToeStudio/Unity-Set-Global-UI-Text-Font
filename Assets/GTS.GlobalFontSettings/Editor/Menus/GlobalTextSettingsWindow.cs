/*

            ChangeAllFontsButton();

            //Event e = Event.current;
            //if(e.commandName != "")
            //    Debug.Log("Command recognized: " + e.commandName);

                AssetProcessor.CreateDefaultTextAsset();
                GlobalTextSettings.TextSettings = AssetProcessor.LoadTextAsset(selctedFont);
        {

            if(GlobalTextSettings.TextSettings != null)
            {
                // Allows us to use the Color Picker to change color.
                if(Event.current.commandName == "ColorPickerChanged")
                    GlobalTextSettings.TextSettings.color = EditorGUILayout.ColorField(GlobalTextSettings.TextSettings.color);

                    PropertyLibrary.ChangeAllColor();
                }
                // Allows us to use the dropper to chagne color.
                else if(Event.current.commandName == "EyeDropperClicked")
                {
                    GlobalTextSettings.TextSettings.color = EditorGUILayout.ColorField(GlobalTextSettings.TextSettings.color);

                    PropertyLibrary.ChangeAllColor();
                }
                {
                    // Do not change color when a new TextData is loaded.
                    EditorGUILayout.ColorField(GlobalTextSettings.TextSettings.color);
                }
            }
            {
                // No TextData, show Black.
                EditorGUILayout.ColorField(Color.black);
            }

            {
                SceneView.lastActiveSceneView.Repaint();
            }
            SceneView.RepaintAll();