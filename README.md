# BattlefieldV Statistics
Since there's no libraries for it yet, here's a C# version for grabbing overview, game mode and class stats of a Origin, XBox or PlayStation account.

[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)

## How it works?
It simply uses an API which when called with the right parameters, will return a JSON with tons of informations about the users' account (Origin, XBox or PlayStation) and the exact statistics of their account.

I found this one while looking in the Network fetched files on **Battlefieldtracker.com** website on Chrome.
` https://api.tracker.gg/api/v2/bfv/standard/profile/origin/raulssorban `

![GitHub Logo](https://i.imgur.com/5nixUaa.png)

Based on that, I wrote a pretty handy wrapper which not only gets all the sections in dictionaries but super easy to quick-access any kind of classes, game modes or read the player's overview.


## Usage
![GitHub Logo](https://i.imgur.com/XxXLosR.png)
