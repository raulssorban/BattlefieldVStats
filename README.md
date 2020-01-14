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
Use the **BattlefieldV** and **BattlefieldV.Components** namespaces to access the API class and User class.
The difference between the two is:
The **BattlefieldV.Components.User** class is the one that grabs all stats, the class which makes the call to the actual server. As the JSON is returned, I raw map them with some basic principle classes in which the data is stored and returned (Segments and Stats), data which follow a pattern, reused with instances of predefined classes. This class also has more raw unused information which you can get for your benefit, if you'll ever need. Check out the Test project for more info.

The **BattlefieldV.API** is the one that you mainly want, it's the 'user-friendly' class in which you can directly access the exact data (for Overview, Game Modes and Classes of a player), using tree properties.

![GitHub Logo](https://i.imgur.com/XxXLosR.png)
