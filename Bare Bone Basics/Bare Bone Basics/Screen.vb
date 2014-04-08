Public Class Screen

    Public Sub Open()
        Windows.Forms.Application.Run(Me) 'MUST HAVE VERY IMPORTANT
        'This puts the form on its own thread so that you can interact with it and have the console do its own thing too
    End Sub

End Class