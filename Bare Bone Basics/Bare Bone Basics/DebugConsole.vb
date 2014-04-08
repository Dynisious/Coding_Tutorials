Module DebugConsole
    'This is the command prompt interface that will open when the program starts.
    'NOTE: The program will close when the console reaches the end of the Main() sub routine so be
    'careful how you set that up.

    Public OutputScreen As New Screen
    'This is the windows form that will actually be displayed and the user will interact with.
    Private ScreenThread As New Threading.Thread(AddressOf OutputScreen.Open) 'MUST BE INCLUDED OR YOU CANNOT INTERACT WITH YOUR FORM
    'Try removing this thread and see what happens (MAKE SURE YOU CAN PUT IT BACK THOUGH)
    'Welcome to multi-threading!!!! Yay!!!!
    'Creating a new thread means the computer does multiple things at the same time!!!! but if two or more threads try to
    'use the same variables at once it causes errors :( how to find and avoid these will be in a later tutorial.

    Sub Main()
        ScreenThread.Start() 'This starts the thread at OutputScreens' Open() sub which then makes the form highjack the thread
        'and use it for its own stuff :)
        'Try removing this line or replacing it with OutputScreen.Open() and see what happens (MAKE SURE YOU CAN PUT IT BACK THOUGH)
        Console.Write("This is {0}:", "being") 'This is a fun way of formatting strings i've found and it can be
        'very helpful when putting in other values
        Console.Write(":Written {0} {1} same line", "on", "the")
        Console.WriteLine()
        Console.WriteLine("This writes on a {0} line", "new")
        Console.WriteLine("Press any key and then enter to end the program")
        Dim txt As String = Console.Read() 'This stops the program until a key is pressed and you can store the keys code as a string or integer
        Console.WriteLine(txt)
        txt = Console.ReadLine() 'This is the same as Read() but it waits untill the user
        'presses 'Enter' and returns the entire line as a string

        End 'Because OutputScreen opened its own process loop (see the description of 'Application.Run') it will actually keep the program open
        'so we either close it and all other forms or we use 'End' which ends the process loops :) easy peasy.
    End Sub

End Module
