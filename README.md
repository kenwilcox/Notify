# Notify
Display's notification messages

Simple arguments, it takes anything passed on the command line and displays it maximized on the main screen. If you want, you can specify a window title too.

##Usage
```
notify.exe This is the message that will be displayed
```
Specifying the title is just as easy. Separate the two with a | character
```
notify.exe Window Title | This is yet another message that will be displayed.
```

NEW: Just added - if you pass in a TimeSpan (hh:mm:ss) it will turn into a countdown timer
```
notify.exe 00:30:00
```
It will also accept a window title
```
notify.exe Lunch Is Over | 00:30:00
```
I'd like to add another argument for a command to execute on a "positive" or OK dismissal of the form, but I don't need it yet. So I haven't added it.

Oh, the examples don't have quotes around the words, the're not needed.
