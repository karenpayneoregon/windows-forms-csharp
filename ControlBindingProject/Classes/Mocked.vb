Namespace Classes
    Public Module Mocked
        Public ReadOnly Property FirstNames() As List(Of String)
            Get
                Return {
                           "Alejandra", "Alexander", "Ana", "Anabela", "André", "Ann", "Annette", "Antonio",
                           "Aria", "Art", "Bernardo", "Carine", "Carlos", "Catherine", "Christina", "Daniel",
                           "Diego", "Dominique", "Eduardo", "Elizabeth", "Felipe", "Fran", "Francisco",
                           "Frédérique", "Georg", "Giovanni", "Guillermo", "Hanna", "Hari", "Helen", "Helvetius",
                           "Henriette", "Horst", "Howard", "Isabel", "Jaime", "Janete", "Janine", "Jean",
                           "John", "Jonas", "Jose", "José", "Jytte", "Karin", "Karl", "Laurence", "Lino", "Liu",
                           "Liz", "Lúcia", "Manuel", "Maria", "Marie", "Mario", "Martín", "Martine", "Mary", "Matti",
                           "Maurizio", "Michael", "Miguel", "Palle", "Paolo", "Pascale", "Patricia", "Patricio", "Paul",
                           "Paula", "Pedro", "Peter", "Philip", "Pirkko", "Renate", "Rene", "Rita",
                           "Roland", "Sergio", "Simon", "Sven", "Thomas", "Victoria", "Yang", "Yoshi", "Yvonne",
                           "Zbyszek"}.ToList
            End Get
        End Property
        Public ReadOnly Property LastNames() As List(Of String)
            Get
                Return {
                           "Accorti", "Afonso", "Anders", "Angel Paolino", "Ashworth", "Batista", "Bennett", "Berglund", "Bergulfsen",
                           "Bertrand", "Braunschweiger", "Brown", "Camino", "Cartrain", "Carvalho", "Chang", "Citeaux", "Cramer",
                           "Crowther", "Cruz", "de Castro", "Devon", "Dewey", "Domingues", "Fernández", "Feuer", "Fonseca",
                           "Franken", "Fresnière", "González", "Gutiérrez", "Hardy", "Henriot", "Hernández", "Holz", "Ibsen",
                           "Izquierdo", "Jablonski", "Josephs", "Karttunen", "Kloss", "Koskitalo", "Kumar", "Labrune", "Larsson",
                           "Latimer", "Lebihan", "Limeira", "Lincoln", "McKenna", "Mendel", "Messner", "Moncada", "Moos", "Moreno",
                           "Moroni", "Müller", "Nagy", "Nixon", "Ottlieb", "Parente", "Pavarotti", "Pedro Freyre", "Pereira", "Perrier",
                           "Petersen", "Pfalzheim", "Phillips", "Piestrzeniewicz", "Pipps", "Pontes", "Rancé", "Rodriguez", "Roel",
                           "Roulet", "Rovelli", "Saavedra", "Saveley", "Schmitt", "Simpson", "Snyder", "Sommer", "Steel", "Tannamuri",
                           "Tonini", "Trujillo", "Wang", "Wilson", "Wong", "Yorres"}.ToList
            End Get
        End Property
    End Module
End Namespace