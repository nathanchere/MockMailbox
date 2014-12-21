# MockMailbox
### A .NET library for generating vaguely interesting mock emails

Initially forked from Gander where it was used for generating mockmailbox data for offline testing. Software like Papercut and nDumpster are great for faking outgoing email but what about incoming?

I decided it might be useful to others who like the AutoFixture style approach of auto-gen-all-of-the-things but want results that more closely reflect real-world data.

[![Send me a tweet](http://nathanchere.github.io/twitter_tweet.png)](https://twitter.com/intent/tweet?screen_name=nathanchere "Send me a tweet") [![Follow me](http://nathanchere.github.io/twitter_follow.png)](https://twitter.com/intent/user?screen_name=nathanchere "Follow me")

## Documentation

MockMailbox is still under development alongside Gander and likely to change significantly. Proper documentation will come if and when it's stablised. A demo project is included which will be the best reference until then. 

If you want to use the demo project to generate mailboxes with sample emails for testing a mail client I recommend Pablo Software Solution's [Baby POP3 Server](http://www.pablosoftwaresolutions.com/html/baby_pop3_server.html). It's not perfect by any means but it's free, light weight and does the job.

In Baby POP3 Server's settings change the "Drop Directory" to somewhere like `%PROGRAMDATA%\MockMail` and set the output for the demo project to the same path. Set up accounts to suit (eg username `jcitizen` password `password`), then generate the mock mails and start the POP3 server.

## Status

Branch | Status | Download | Description
------|-----|------|--------
master | [![Build status](https://ci.appveyor.com/api/projects/status/93dn556v0jw4q6la/branch/master)](https://ci.appveyor.com/project/nathanchere/nfmod) | [.zip](https://github.com/nathanchere/nFMOD/archive/master.zip) | for those who want to live on the bleeding edge
stable | [![Build status](https://ci.appveyor.com/api/projects/status/93dn556v0jw4q6la/branch/stable)](https://ci.appveyor.com/project/nathanchere/nfmod) | [.zip](https://github.com/nathanchere/nFMOD/archive/stable.zip) | latest released/numbered code

*CI generously provided by [Appveyor](http://appveyor.com)*

How I approach my public projects is explained on [my github home page](http://nathanchere.github.io).

## Release history

#### vNext (2014-??)

* initial release to Nuget
* minimum .Net Framework version lowered from 4.0 > 2.0
* namespace restructuring

#### vAlpha (2014-12-21)

* initial fork from Gander and release to GitHub
* Viking, Ninja Turtle and Elf themed email generators

## Credits / thanks

* [LucidDion](http://firelightstudios.net/): for the Markov name generator implementation [FMOD](http://www.fmod.org/) used to create pseudo-random email usernames 