The included code sets up a level for a dancing game, where the player controls characters to dance with a sense of harmony.  This code can be used to programmatically set up a variety of levels in different games.  The advantage of programmatically building levels is that loops can be used, and the scene's hierarchy has fewer objects. In addition, only the AimBuildInstructions0 file needs to be modified when adding or rearranging levels.

Code is first run in AimController.  "Aim" here is used to mean an objective or level of a game.  The AimBuilder then creates an empty game object, and the instructions fill in this new game object with characters (obstacles or traps could be added here as well).  AimSequence is used to progress through the levels.  The variable aimSequenceMarker is the level that the player last completed, which I have stored in PlayerPrefs.

I have the following code run in Unity's Start() function in my GameController class: this.aimController.Initialize(this.gamePrefs.GetNextAimId());

To access the current level, this line is called: this.aimController.BuildAim()

The programmer then has access to the current Aim, which has methods that return the items in the level.

Note: I often use "this." redundantly in my own projects as a matter of style.  Also, an improvement to make would be to have the AimBuildInstructions0 object be passed in for flexibility.