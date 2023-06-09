# FasterDD2
Simple Darkest Dungeon 2 example speed mod (1-3x) using MelonLoader.
Doesn't affect narrator/music.
For personal use.

![image](https://github.com/stefanescu/FasterDD2/assets/5994641/ff035176-f4d4-40f9-9d84-fc2d197ae37d)

**REQ**

MelonLoader Mod Loader `0.5.7` https://melonwiki.xyz/#/README

**INSTALL**
1) Download MelonLoader Installer from https://melonwiki.xyz/#/README (install requirements)
2) Locate "Darkest Dungeon II.exe" in your GameDir
3) _**Untick Auto checkbox and select MelonLoader version `0.5.7`, NOT `6+`**_
4) Leave Game Arch to **Auto**
5) Install MelonLoader, which creates `/Mods` next to .exe
6) Download [FasterDD2.dll](https://github.com/stefanescu/FasterDD2/blob/9a364af61ab8a19a1605e564a0a92619c008b6c6/Fasterdd2.dll) from this repo and place it in `/Mods`
7) Your .exe will **Always** use everything in the Mods folder, unless you start it with `--no-mods`

**Wanna play without mods?**
`--no-mods` Launch Argument OR
move the `/Mods` dir somewhere else OR
Uninstall MelonLoader

**BUILD**

MelonLoader Requirements (for Mono runtime) https://melonwiki.xyz/#/modders/quickstart

DD2 uses Mono in Unity 2020.3.7

![image](https://github.com/stefanescu/FasterDD2/assets/5994641/e97c7d35-532a-4652-83b2-5bd6ae1cd218)

 1) Visual Studio (2022)
 2) In Project Properties
 ![image](https://github.com/stefanescu/FasterDD2/assets/5994641/08d12445-2da6-4b75-b50b-922fd004db10)

 3)
 ![image](https://github.com/stefanescu/FasterDD2/assets/5994641/ae1fd8b3-c19c-42e5-825e-6504ff364d79)
 Need these 4 references. If missing,
 Right click References > Add
  
From ![image](https://github.com/stefanescu/FasterDD2/assets/5994641/0fe3efeb-3c30-49c9-98ee-e5dd6f530097)

4) Build?
 

  
  
**Known Issues**
1) If using Steer-with-mouse option, your cart will stop if you press Speed buttons during travel. Click again to start travel. No plans to fix it. 

Future Game Updates **might** break functionality (probably won't).
