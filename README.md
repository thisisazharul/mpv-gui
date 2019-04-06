# mpv.net

mpv.net is a libmpv based media player for Windows, it looks and works like mpv and also shares the same settings as mpv and therefore the mpv documentation applies.

mpv and mpv.net have a learning curve.

mpv manual: <https://mpv.io/manual/master/>

Table of contents
-----------------

- [Features](#features)
- [Screenshots](#screenshots)
- [Context Menu](#context-menu)
- [Settings](#settings)
- [Scripting](#scripting)
- [Support](#support)
- [Changelog](#changelog)

### Features

- Customizable context menu defined in the same file as the key bindings
- Searchable options dialog with modern UI as mpv compatible standalone application
- Searchable input (key/mouse) binding editor with modern UI as mpv compatible standalone application
- Rich addon API for .NET languages
- Rich scripting API for Python, C#, Lua, JavaScript and PowerShell
- mpv's OSC (on screen controller (play control bar)), IPC, conf files

### Screenshots

![](https://raw.githubusercontent.com/stax76/mpv.net/master/screenshots/mpvnet.png)

![](https://raw.githubusercontent.com/stax76/mpv.net/master/screenshots/mpvConfEdit.png)

![](https://raw.githubusercontent.com/stax76/mpv.net/master/screenshots/mpvInputEdit.png)

### Context Menu

The context menu can be customized via input.conf file located at:
```
C:\Users\username\AppData\Roaming\mpv\input.conf
```
if it's missing mpv.net generates it with the following defaults:

<https://github.com/stax76/mpv.net/blob/master/mpv.net/Resources/input.conf.txt>

### Settings

mpv.net shares the settings with mpv, settings can be edited in a settings dialog or in a config file called mpv.conf located at:
```
C:\Users\user\AppData\Roaming\mpv\mpv.conf
```
if it's missing mpv.net generates it with the following defaults:

<https://github.com/stax76/mpv.net/blob/master/mpv.net/Resources/mpv.conf.txt>

### Scripting

Scripting is supported for Python, C#, Lua, JavaScript and PowerShell

https://github.com/stax76/mpv.net/wiki/Scripting-(CSharp,-Python,-JavaScript,-Lua,-PowerShell)

### Support

<https://forum.doom9.org/showthread.php?t=174841>

<https://forum.videohelp.com/threads/392514-mpv-net-a-extendable-media-player-for-windows>

<https://github.com/stax76/mpv.net/issues>

### Changelog

### 2.4 (2019-04-06)

- new options added to the conf GUI editor: gpu-context, gpu-api, scale, cscale, dscale, dither-depth, correct-downscaling, sigmoid-upscaling, deband
- the conf edit GUI has a 'Apply' feature added to write the conf to mpv.conf without the need to close the conf edit GUI
- the input edit GUI shows a message box when a duplicate is detected and it has a new feature to reduce the filter scope to eather of input, menu or command and the editor writes always the same help on top of input.conf as it is found in the defaults 
- the conf edit GUI was often starting out of working area bounds and is now starting with center screen
- the startup size was reduced and a issue was fixed that when the screen property was defined for a screen that isn't connected the startup size wasn't applied
- added feature to load external audio and subtitle files in the menu under: Open > Load external audio|subtitle files (default binding at: [input.conf](https://github.com/stax76/mpv.net/blob/master/mpv.net/Resources/input.conf.txt))
- previously the conf edit GUI removed settings from the conf file if the setting was set to the default, the new behavior is not to remove anything
- the autofit mpv property was partly implemented, you can use 'autofit = 50%' in mpv.conf or '--autofit=50%' on the command line, WxH isn't implemented and only percent values are accepted. There is a new wiki page explaining the mpv.net limitations compared to the original mpv: [Limitations](https://github.com/stax76/mpv.net/wiki/Limitations)

### 2.3 (2019-04-04)

- dragging a youtube URL on mpv.net would still break something, it should work now
- when the main window gets focus/activation it will check the clibboard for a YouTube video and ask to play it
- libmpv updated
- changing to normal size from fullscreen resulted in a too large window in some circumstances
- some default key bindings and menu structure have changed and the input.conf file has a description added on top <https://github.com/stax76/mpv.net/blob/master/mpv.net/Resources/input.conf.txt>
- the file association code was completely rewriten, it's now contained within mpvnet.exe instead of a separate application and it adds a few more keys
- various new info added to the wiki: <https://github.com/stax76/mpv.net/wiki>
- On Top feature was implemented using mpv's native property 'ontop', default bindings at: <https://github.com/stax76/mpv.net/blob/master/mpv.net/Resources/input.conf.txt>

### 2.2 (2019-04-01)

- messages boxes had always the info icon even if a different icon (error, warning, question) was intended
- instead of silently do nothing on unknown commands there is now a error message listing available commands and showing the location of the default bindings, this helps when commands are removed or renamed
- there was a problem fixed that made the cursor hidden when it should be visible
- dragging a youtube URL on mpv.net would break certain input related features
- there is now an installer with file extension registration (limited on Win 10) available
- WM_APPCOMMAND media keys were not working in the input (shortcut) editor and there were no defaults for prev and next defined