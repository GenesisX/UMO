Rewrite project of UtaMacross mobile game. 

**Current version : 0.6**

Fonctionality : 
* Basic loading of the game with default profile (all costume/cards unlocked and fully leveled)
* Main menu : Music/Home, Diva, SNS, Home bg switch, Home diva switch, Memory zone, Deco room buttons works.
* Playing song :
  * Editor gameplay : Use key S-D-F-H-J-K for the 6 lanes, and D-F-H-J for 4 lanes songs. Slide note are automatically valided on hit. Lane change on 6 lane mode don't work. Key can be changed in the options (menu UMO > Options).
* A few event can be activated (Apil fools, ...). Can be acceded from UMO Setting popup on the title screen (pad icon)

# Requirement

* The game data dump with android and db directories. For legal reason and size, this cannot be avaiable here. Game can load from encrypted or decrypted bundle, with name format like bundle.xab, bundle.xab.decrypted, bundle!sxxxxxxz!.xab, bundle!sxxxxxxz!.xab.decrypted. Check the Tools directory to get the game data (this method can stop working anytime).
* **PC** : Unity version 2018.4.23f1 or 2018.4.24f1
  * **For linux user** : FFMpeg installed to convert movies. If not installed, check "Disable movies" in the options.
* **Android** : a phone compatible with Arm7 apk. Some emulator or x86 phone can possibly run it too if they use libhoudini.

# Installation

* **Android**:
  * Download the apk and one zip of the UMOServer (linux or windows)
  * Install the apk on your phone. Could require allowing the install of untrusted apk.
  * Run the game, the first time, it will need to download the game datas. Whenever it is the case, a popup will open telling you to run the server on a pc on the local network. To do so :
    * Run the UMO Server executabe.
    * In the input box on top, copy the path where you put the original game data (the directory containing android & db directory)
    * Press Start Server. On windows, accept the firewall security. (Server use port 8000, server discovery by broadcast use port 8001).
    * The log should display it is ready.
    * The phone should auto-detect the server running and download the data. Once in the main menu, you can close the server. **The phone and the server should be on the same local network**.
    * If the game don't find the server, it the cancel button and enter the local IP of the PC running the server.
    * The game can freeze during download, just restart it.
* **PC** : 
  * Clone the project or extract the release zip (If you extract the zip on a older installation, remove the Unity directory before doing so).
  * For automatic game data detection, you can copy android and db directory from the game dump into Tools/Data/
  * Launch Unity Editor 2018.4.23f1 or 2018.4.24f1 (Accept the upgrade asset popup), load the project in Unity folder.
  * **Linux user** : You can convert all the movies instead of when needed with the menu UMO > Convert all movies. This use FFMpeg and take a long time.
  * Start the game using the menu UMO > Start Game.
  * The game will search game data in Tools/Data or Data directory (default directories when using python script to download from game server). If you put your game data elsewhere, select the directory containing "android" and "db" directories in the next popup. For advanced configuration, you can check the options.

# Project usage in Unity Editor.
**Menu UMO**
* Start Game : Start the game.
* Start Auto SLive Viewer : Start the game in automatic mode, randomply selecting songs and diva costumes.
* Options : Open a window with UMO specific options
  * Profile
    * Force tuto skip : Unused actually
    * Can skip unplayed songs : Allow the skip button to be enabled even for song never played
  * Live
    * Force Live Valkyrie Mode : Force going in valkyrie mode even if gauge is not filled
    * Force Live Diva Mode : Force going in standard diva mode
    * Force Live Awaken Diva Mode : Force going on awaken diva mode
    * Touch* : Select the key to use for each lane and the active skill button.
  * S-Live
    * Disable Movies : Disable playing movies
  * Data Directory : Local directory where game data was downloaded.
  * Data Web server URL : URL Where to download data (this require uploading the data somewhere accessible on a web server)
  * Debug : Debug options for dev.
* Copy song setup for bug report : Allow to generate the song infos to help doing the report.
* Create song notes data : Allow to generate a log of a song play to help doing a bug report when tapping note is broken.
* (Linux user) Convert all movies. Allow to convert all movies at once.

# UMO settings / event start

Settings and starting event can be done from the config popup. It is accessible from the pad button in the title screen.

# Android troubleshooting :
* It's possible the game crash or stuff can be wrongly displayed because there was an error when downloading the file. If you use the encrypted version of the data, you can force a recheck of the files by clicking on the gamepad icon the the start menu, selecting the option to force recheck and start the game. It will recheck all files (take a long time). If you use the decrypted version of the data, for now all the files will be redownloaded. This is because the game expect the crypted data for comparing data for now, this will be fixed at a later time.

# Used library :

* [VGMToolbox](https://sourceforge.net/projects/vgmtoolbox/) to load acb/awb and usm files
* [DereTore](https://github.com/OpenCGSS/DereTore) to play hca files
* [Flatbuffers](https://google.github.io/flatbuffers/) to read database
* [LitJson](https://litjson.net/) to read some json
* [LibVLC](https://code.videolan.org/videolan/vlc) / [LibVLCSharp](https://code.videolan.org/videolan/LibVLCSharp) to play the movies
