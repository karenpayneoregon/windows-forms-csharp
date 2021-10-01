Namespace My
    <ComponentModel.EditorBrowsable(ComponentModel.EditorBrowsableState.Never)>
    Partial Friend Class _MyImages

        Private ReadOnly MyProperties As Reflection.PropertyInfo()
        Private ReadOnly MyBitmapNames As List(Of String)
        Private BitMapImages As Dictionary(Of String, Bitmap)

        Private Sub GetBitMapImages()

            BitMapImages = New Dictionary(Of String, Bitmap)

            Dim propertyInfo As Reflection.PropertyInfo() =
                GetType(Resources.Resources).GetProperties(Reflection.BindingFlags.NonPublic Or
                                                              Reflection.BindingFlags.Instance Or
                                                              Reflection.BindingFlags.Static)

            Dim BitMaps = (From T In propertyInfo Where T.PropertyType Is GetType(Bitmap)).ToList

            If BitMaps.Count > 0 Then
                For Each pInfo As Reflection.PropertyInfo In BitMaps

                    BitMapImages.Add(
                        pInfo.Name.Replace("_", " "),
                        CType(Resources.ResourceManager.GetObject(pInfo.Name), Bitmap)
                    )

                Next
            End If

        End Sub
        ''' <summary>
        ''' Gets a image from resource or if not found a blank image
        ''' </summary>
        ''' <param name="sender">Name of an existing item in My.Resources</param>
        ''' <returns></returns>
        ''' <remarks>
        ''' For this demo I return a transparent bitmap, feel free to change.
        ''' </remarks>
        Public Function BitmapFromResource(sender As String) As Bitmap

            Dim Item = (
                    From propertyInfo In MyProperties
                    Where propertyInfo.PropertyType Is GetType(Bitmap) AndAlso propertyInfo.Name = sender
                    ).FirstOrDefault

            If Item IsNot Nothing Then
                Return CType(Resources.ResourceManager.GetObject(Item.Name), Bitmap)
            Else
                Dim bm As New Bitmap(256, 256)
                Dim gr As Graphics = Graphics.FromImage(bm)
                gr.Clear(Color.Transparent)

                Return bm

            End If

        End Function
        ''' <summary>
        ''' Returns a list of bitmap names in this project resources w/ extension
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public ReadOnly Property BitmapNames As List(Of String)
            Get
                Return MyBitmapNames
            End Get
        End Property
        Public Sub New()

            MyProperties = GetType(Resources.Resources).
                GetProperties(
                    Reflection.BindingFlags.NonPublic Or
                    Reflection.BindingFlags.Instance Or
                    Reflection.BindingFlags.Static)

            MyBitmapNames = (
                From propertyInfo In MyProperties
                Where propertyInfo.PropertyType Is GetType(Bitmap)
                Select propertyInfo.Name
                ).ToList

            GetBitMapImages()

        End Sub
    End Class
    <HideModuleName()>
    Friend Module Resource_Images
        Private ReadOnly instance As New ThreadSafeObjectProvider(Of _MyImages)
        ReadOnly Property Images() As _MyImages
            Get
                Return instance.GetInstance()
            End Get
        End Property
    End Module
End Namespace

