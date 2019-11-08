Imports System.Text
Imports CaractereCopieur

'Intro (Kata)
' Le copieur de caractère est une classe simple qui lit les caractères à partir d'une source et les copie vers une destination, un caractère à la fois.
' Le copieur de caractère obtient la source et la destination injectées dans le constructeur.
' Lorsque la méthode de copie est appelée par le copieur, il devrait lire les caractères à partir de la source et les copier vers la destination jusqu'à ce que la source 
' retourne un saut de ligne ('\n') ou la constante vbLf par exemple.
' L'exercice consiste à mettre le copieur de caractère à l'aide objets "mockés" de la source et la destination 
' Les étapes suggérés:
'   1. En premier, y aller avec des objets "mockés ou stubés" manuellement 
'   2. Par la suite, refaire les tests avec le cadre ou "framework" d'isolation NSubstitute (on donnera des explications rendu là).
'   3. Noter bien qu'il y a plusieurs manière de tester et de faire des assertions avec NSubstitute
'   4. Faire des tests différents pour l'état et l'interaction
'   5. Faire le test manuel à fin avec la console
'   6. Voir comment éliminer la duplication dans vos tests.  Ex: étape  <TestInitialize()>


<TestClass()>
Public Class CaractereCopieurTests

    <TestMethod()>
    Public Sub TestMethod1()
      
    End Sub

   
End Class








